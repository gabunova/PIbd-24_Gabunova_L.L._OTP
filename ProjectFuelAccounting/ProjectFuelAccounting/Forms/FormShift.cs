using ProjectFuelAccounting.Entities;
using ProjectFuelAccounting.Entities.Enums;
using ProjectFuelAccounting.Repositories;

namespace ProjectFuelAccounting.Forms;

public partial class FormShift : Form
{
    private readonly IShiftRepository _shiftRepository;

    public FormShift(IShiftRepository shiftRepository, IDriverRepository driverRepository, ICarRepository carRepository, IRouteRepository routeRepository)
    {
        InitializeComponent();
        _shiftRepository = shiftRepository ?? throw new ArgumentNullException(nameof(shiftRepository));

        comboBoxDriver.DataSource = driverRepository.ReadDrivers();
        comboBoxDriver.DisplayMember = "FullName";
        comboBoxDriver.ValueMember = "Id";

        comboBoxCar.DataSource = carRepository.ReadCars();
        comboBoxCar.DisplayMember = "CarNumber";
        comboBoxCar.ValueMember = "Id";

        comboBoxShiftType.DataSource = Enum.GetValues(typeof(ShiftType));

        ColumnRoute.DataSource = routeRepository.ReadRoutes();
        ColumnRoute.DisplayMember = "Name";
        ColumnRoute.ValueMember = "Id";
    }

    private void ButtonSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (dataGridViewRoutes.RowCount < 1 ||
                comboBoxDriver.SelectedIndex < 0 ||
                comboBoxCar.SelectedIndex < 0 ||
                comboBoxShiftType.SelectedIndex < 1)
            {
                throw new Exception("Имеются незаполненные поля");
            }
            _shiftRepository.CreateShift(Shift.CreateOperation(
                0,
                (int)comboBoxDriver.SelectedValue!,
                (int)comboBoxCar.SelectedValue!,
                (ShiftType)comboBoxShiftType.SelectedItem!,
                CreateListShiftRoutesFromDataGrid()));
            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void ButtonCancel_Click(object sender, EventArgs e) => Close();

    private List<ShiftRoute> CreateListShiftRoutesFromDataGrid()
    {
        var list = new List<ShiftRoute>();
        foreach (DataGridViewRow row in dataGridViewRoutes.Rows)
        {
            if (row.Cells["ColumnRoute"].Value == null || row.Cells["ColumnFuelSpent"].Value == null)
            {
                continue;
            }
            list.Add(ShiftRoute.CreateElement(
                0,
                Convert.ToInt32(row.Cells["ColumnRoute"].Value),
                Convert.ToDouble(row.Cells["ColumnFuelSpent"].Value)));
        }
        return list;
    }
}