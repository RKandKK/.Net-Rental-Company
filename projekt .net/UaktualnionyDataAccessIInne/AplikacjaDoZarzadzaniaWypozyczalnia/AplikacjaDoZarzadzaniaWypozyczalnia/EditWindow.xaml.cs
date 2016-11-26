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

namespace AplikacjaDoZarzadzaniaWypozyczalnia
{
    /// <summary>
    /// Interaction logic for EditWindow.xaml
    /// </summary>
    public partial class EditWindow : Window
    {
        ViewModel vm;
        public EditWindow(ViewModel vm)
        {
            this.vm = vm;
            InitializeComponent();
        }

        private void buttonZatwierdz_Click(object sender, RoutedEventArgs e)
        {
            if (NowaCena.Value != null && NowaCena.Value.Value > 0)
            { vm.VehicleRepository.ChangePrice(vm.SelectedVehicle, NowaCena.Value.Value); vm.GetList(); DialogResult = true; Close(); }
            else
                MessageBox.Show("Podaj cenę większą od 0.");
        }

        private void buttonAnuluj_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void buttonUsun_Click(object sender, RoutedEventArgs e)
        {
            vm.VehicleRepository.RemoveVehicle(vm.SelectedVehicle);
            DialogResult = true;
            vm.GetList();
            Close();
        }
    }
}
