using ProjectFuelAccounting.Entities;
using ProjectFuelAccounting.Entities.Enums;
using ProjectFuelAccounting.Repositories;

namespace ProjectFuelAccounting.Forms;

public partial class FormDriver : Form
{
    private readonly IDriverRepository _driverRepository;
    private int? _driverId;

    public int Id
    {
        set
        {
            try
            {
                var driver = _driverRepository.ReadDriverById(value);
                if (driver == null)
                {
                    throw new InvalidDataException(nameof(driver));
                }
                textBoxFullName.Text = driver.FullName;
                textBoxLicenseNumber.Text = driver.LicenseNumber;
                numericUpDownExperience.Value = driver.Experience;
                foreach (VehicleCategory elem in Enum.GetValues(typeof(VehicleCategory)))
                {
                    if ((elem & driver.AllowedCategory) != 0)
                    {
                        checkedListBoxCategories.SetItemChecked(checkedListBoxCategories.Items.IndexOf(elem), true);
                    }
                }
                _driverId = value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при получении данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }

    public FormDriver(IDriverRepository driverRepository)
    {
        InitializeComponent();
        _driverRepository = driverRepository ?? throw new ArgumentNullException(nameof(driverRepository));
        foreach (var elem in Enum.GetValues(typeof(VehicleCategory)))
        {
            checkedListBoxCategories.Items.Add(elem);
        }
    }

    private void ButtonSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(textBoxFullName.Text) ||
                string.IsNullOrWhiteSpace(textBoxLicenseNumber.Text) ||
                checkedListBoxCategories.CheckedItems.Count == 0)
            {
                throw new Exception("Имеются незаполненные поля");
            }
            if (_driverId.HasValue)
            {
                _driverRepository.UpdateDriver(CreateDriver(_driverId.Value));
            }
            else
            {
                _driverRepository.CreateDriver(CreateDriver(0));
            }
            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void ButtonCancel_Click(object sender, EventArgs e) => Close();

    private Driver CreateDriver(int id)
    {
        VehicleCategory categories = VehicleCategory.None;
        foreach (var elem in checkedListBoxCategories.CheckedItems)
        {
            categories |= (VehicleCategory)elem;
        }
        return Driver.CreateEntity(id, textBoxFullName.Text, textBoxLicenseNumber.Text,
            Convert.ToInt32(numericUpDownExperience.Value), categories);
    }
}