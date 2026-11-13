using ProjectFuelAccounting.Entities;
using ProjectFuelAccounting.Repositories;

namespace ProjectFuelAccounting.Forms;

public partial class FormRoute : Form
{
    private readonly IRouteRepository _routeRepository;
    private int? _routeId;

    public int Id
    {
        set
        {
            try
            {
                var route = _routeRepository.ReadRouteById(value);
                if (route == null)
                {
                    throw new InvalidDataException(nameof(route));
                }
                textBoxName.Text = route.Name;
                numericUpDownDistance.Value = (decimal)route.Distance;
                _routeId = value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при получении данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }

    public FormRoute(IRouteRepository routeRepository)
    {
        InitializeComponent();
        _routeRepository = routeRepository ?? throw new ArgumentNullException(nameof(routeRepository));
    }

    private void ButtonSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                throw new Exception("Имеются незаполненные поля");
            }
            if (_routeId.HasValue)
            {
                _routeRepository.UpdateRoute(CreateRoute(_routeId.Value));
            }
            else
            {
                _routeRepository.CreateRoute(CreateRoute(0));
            }
            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void ButtonCancel_Click(object sender, EventArgs e) => Close();

    private Route CreateRoute(int id) => Route.CreateEntity(
        id,
        textBoxName.Text,
        Convert.ToDouble(numericUpDownDistance.Value));
}