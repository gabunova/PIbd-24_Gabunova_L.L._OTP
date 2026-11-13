using ProjectFuelAccounting.Entities;
using ProjectFuelAccounting.Repositories;

namespace ProjectFuelAccounting.Forms;

public partial class FormRefuel : Form
{
    private readonly IRefuelRepository _refuelRepository;

    public FormRefuel(IRefuelRepository refuelRepository, ICarRepository carRepository, IDriverRepository driverRepository)
    {
        InitializeComponent();
        _refuelRepository = refuelRepository ?? throw new ArgumentNullException(nameof(refuelRepository));

        comboBoxCar.DataSource = carRepository.ReadCars();
        comboBoxCar.DisplayMember = "CarNumber";
        comboBoxCar.ValueMember = "Id";

        comboBoxDriver.DataSource = driverRepository.ReadDrivers();
        comboBoxDriver.DisplayMember = "FullName";
        comboBoxDriver.ValueMember = "Id";
    }

    private void ButtonSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (comboBoxCar.SelectedIndex < 0 || comboBoxDriver.SelectedIndex < 0)
            {
                throw new Exception("Имеются незаполненные поля");
            }
            _refuelRepository.CreateRefuel(Refuel.CreateOperation(
                0,
                (int)comboBoxCar.SelectedValue!,
                (int)comboBoxDriver.SelectedValue!,
                Convert.ToDouble(numericUpDownFuelAmount.Value)));
            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void ButtonCancel_Click(object sender, EventArgs e) => Close();
}