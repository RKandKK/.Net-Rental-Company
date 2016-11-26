using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Domain;
using Microsoft.Win32;

namespace AplikacjaDoZarzadzaniaWypozyczalnia
{
    /// <summary>
    /// Interaction logic for AddVehicleWindow.xaml
    /// </summary>
    public partial class AddVehicleWindow : Window
    {
        string path;
        ViewModel vm;
        public AddVehicleWindow(ViewModel vm)
        {
            this.vm = vm;
            path = "";
            InitializeComponent();
        }

        private void buttonAnuluj_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            comboBoxLicense.ItemsSource = Enum.GetValues(typeof(Domain.DriversLicense)).Cast<Domain.DriversLicense>();
            comboBoxType.ItemsSource = Enum.GetValues(typeof(Domain.VehicleType)).Cast<Domain.VehicleType>();
        }

        private void choosepic_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Select a picture";
            op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
              "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
              "Portable Network Graphic (*.png)|*.png";
            if (op.ShowDialog() == true)
            {
                path = op.FileName;
                this.choosepic.IsEnabled = false;
            }
        }

        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {

            if (verification())
            {
                Vehicle veh = new Vehicle((Domain.VehicleType)comboBoxType.SelectedItem, price.Value.Value, (int)consumption.Value.Value, (Domain.DriversLicense)comboBoxLicense.SelectedItem, textBoxName.Text, vmax.Value.Value, trunk.Value.Value);
                byte[] image = Converters.ImageConverter.BitmapToByte(new BitmapImage(new Uri(path)));
                veh.SetImage(image);
                vm.VehicleRepository.AddVehicle(veh);
                vm.GetList();
                Close();

            }
            else MessageBox.Show("Błędne dane");
        }
        private bool verification()
        {
            if(textBoxName.Text=="")
            {
                MessageBox.Show("Proszę wprowadzić nazwę.");
                return false;
            }
            if (comboBoxType.SelectedItem==null)
            {
                MessageBox.Show("Proszę wprowadzić typ pojazdu.");
                return false;
            }
            if (comboBoxLicense.SelectedItem == null)
            {
                MessageBox.Show("Proszę wprowadzić typ prawa jazdy potrzebny do prowadzenia pojazdu.");
                return false;
            }
            if (consumption.Value == null || consumption.Value.Value<=0)
            {
                MessageBox.Show("Wartość spalania nie może być pusta i musi być większa od zera.");
                return false;
            }
            if(price.Value == null || price.Value.Value<=0)
            {
                MessageBox.Show("Cena nie może być pusta i musi być większa od zera.");
                return false;
            }
            if (trunk.Value == null || trunk.Value.Value <= 0)
            {
                MessageBox.Show("Pojemność bagażnika nie może być pusta i musi być większa od 0.");
                return false;
            }
            if (vmax.Value == null || vmax.Value.Value <= 0)
            {
                MessageBox.Show("Prędkość maksymalna nie może być pusta i musi być większa od 0.");
                return false;
            }
            if(path=="" || path==null)
            {
                MessageBox.Show("Nie wybrano zdjęcia.");
                return false;
            }
            return true;
        }
    }
}
