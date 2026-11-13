using ProjectFuelAccounting.Repositories;
using Unity;

namespace ProjectFuelAccounting.Forms;

public partial class FormRefuels : Form
{
    private readonly IUnityContainer _container;
    private readonly IRefuelRepository _refuelRepository;

    public FormRefuels(IUnityContainer container, IRefuelRepository refuelRepository)
    {
        InitializeComponent();
        _container = container ?? throw new ArgumentNullException(nameof(container));
        _refuelRepository = refuelRepository ?? throw new ArgumentNullException(nameof(refuelRepository));
    }

    private void FormRefuels_Load(object sender, EventArgs e)
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
            _container.Resolve<FormRefuel>().ShowDialog();
            LoadList();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при добавлении", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void LoadList() => dataGridViewData.DataSource = _refuelRepository.ReadRefuels();
}