using ProjectFuelAccounting.Entities;
using ProjectFuelAccounting.Entities.Enums;
using ProjectFuelAccounting.Repositories;

namespace ProjectFuelAccounting.Forms;

public partial class FormCar : Form
{
    private readonly ICarRepository _carRepository;
    private int? _carId;

    public int Id
    {
        set
        {
            try
            {
                var car = _carRepository.ReadCarById(value);
                if (car == null)
                {
                    throw new InvalidDataException(nameof(car));
                }
                textBoxBrand.Text = car.Brand;
                textBoxCarNumber.Text = car.CarNumber;
                numericUpDownFuelRate.Value = (decimal)car.FuelRate;
                comboBoxCategory.SelectedItem = car.Category;
                _carId = value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при получении данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }

    public FormCar(ICarRepository carRepository)
    {
        InitializeComponent();
        _carRepository = carRepository ?? throw new ArgumentNullException(nameof(carRepository));
        comboBoxCategory.DataSource = Enum.GetValues(typeof(VehicleCategory));
    }

    private void ButtonSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(textBoxBrand.Text) ||
                string.IsNullOrWhiteSpace(textBoxCarNumber.Text) ||
                comboBoxCategory.SelectedIndex < 1)
            {
                throw new Exception("Имеются незаполненные поля");
            }
            if (_carId.HasValue)
            {
                _carRepository.UpdateCar(CreateCar(_carId.Value));
            }
            else
            {
                _carRepository.CreateCar(CreateCar(0));
            }
            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void ButtonCancel_Click(object sender, EventArgs e) => Close();

    private Car CreateCar(int id) => Car.CreateEntity(
        id,
        textBoxBrand.Text,
        textBoxCarNumber.Text,
        Convert.ToDouble(numericUpDownFuelRate.Value),
        (VehicleCategory)comboBoxCategory.SelectedItem!);
}