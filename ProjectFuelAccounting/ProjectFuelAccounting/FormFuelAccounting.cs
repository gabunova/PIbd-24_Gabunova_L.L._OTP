using ProjectFuelAccounting.Forms;
using Unity;

namespace ProjectFuelAccounting;

public partial class FormFuelAccounting : Form
{
    private readonly IUnityContainer _container;

    public FormFuelAccounting(IUnityContainer container)
    {
        InitializeComponent();
        _container = container ?? throw new ArgumentNullException(nameof(container));
    }

    private void DriversToolStripMenuItem_Click(object sender, EventArgs e)
    {
        try
        {
            _container.Resolve<FormDrivers>().ShowDialog();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при загрузке", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void CarsToolStripMenuItem_Click(object sender, EventArgs e)
    {
        try
        {
            _container.Resolve<FormCars>().ShowDialog();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при загрузке", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void RoutesToolStripMenuItem_Click(object sender, EventArgs e)
    {
        try
        {
            _container.Resolve<FormRoutes>().ShowDialog();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при загрузке", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void RefuelsToolStripMenuItem_Click(object sender, EventArgs e)
    {
        try
        {
            _container.Resolve<FormRefuels>().ShowDialog();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при загрузке", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void ShiftsToolStripMenuItem_Click(object sender, EventArgs e)
    {
        try
        {
            _container.Resolve<FormShifts>().ShowDialog();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при загрузке", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}