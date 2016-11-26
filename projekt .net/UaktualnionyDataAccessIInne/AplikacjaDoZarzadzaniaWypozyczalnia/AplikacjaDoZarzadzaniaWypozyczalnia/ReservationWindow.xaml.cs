using DataAccess;
using Domain;
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

namespace AplikacjaDoZarzadzaniaWypozyczalnia
{
    /// <summary>
    /// Interaction logic for ReservationWindow.xaml
    /// </summary>
    public partial class ReservationWindow : Window
    {
        private ViewModel vm;
        public ReservationWindow(ViewModel vm)
        {
            this.vm = vm;
            this.DataContext = vm.SelectedVehicle;
            InitializeComponent();
        }

        private void Wynajmij(object sender, RoutedEventArgs e)
        {
            ReservationForm rf = new ReservationForm(vm);
            rf.ShowDialog();
        }

        private void Edytuj_Click(object sender, RoutedEventArgs e)
        {
            EditWindow ew = new EditWindow(vm);
            ew.ShowDialog();
            if (ew.DialogResult.Value) Close();
        }

        private void buttonRate_Click(object sender, RoutedEventArgs e)
        {
            RateWindow rw = new RateWindow(vm);
            rw.ShowDialog();
        }
    }
}
