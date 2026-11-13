using ProjectFuelAccounting.Repositories;
using Unity;

namespace ProjectFuelAccounting.Forms;

public partial class FormShifts : Form
{
    private readonly IUnityContainer _container;
    private readonly IShiftRepository _shiftRepository;

    public FormShifts(IUnityContainer container, IShiftRepository shiftRepository)
    {
        InitializeComponent();
        _container = container ?? throw new ArgumentNullException(nameof(container));
        _shiftRepository = shiftRepository ?? throw new ArgumentNullException(nameof(shiftRepository));
    }

    private void FormShifts_Load(object sender, EventArgs e)
    {
        try
        {
            LoadList();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при загрузке", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void ButtonAdd_Click(object sender, EventArgs e)
    {
        try
        {
            _container.Resolve<FormShift>().ShowDialog();
            LoadList();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при добавлении", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void ButtonDel_Click(object sender, EventArgs e)
    {
        if (!TryGetIdentifierFromSelectedRow(out var findId))
        {
            return;
        }
        if (MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.YesNo) != DialogResult.Yes)
        {
            return;
        }
        try
        {
            _shiftRepository.DeleteShift(findId);
            LoadList();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при удалении", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void LoadList() => dataGridViewData.DataSource = _shiftRepository.ReadShifts();

    private bool TryGetIdentifierFromSelectedRow(out int id)
    {
        id = 0;
        if (dataGridViewData.SelectedRows.Count < 1)
        {
            MessageBox.Show("Нет выбранной записи", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        id = Convert.ToInt32(dataGridViewData.SelectedRows[0].Cells["Id"].Value);
        return true;
    }
}