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
    /// Interaction logic for RateWindow.xaml
    /// </summary>
    public partial class RateWindow : Window
    {
        ViewModel vm;
        public RateWindow(ViewModel vm)
        {
            this.vm = vm;
            InitializeComponent();
        }
        
        private void buttonAnuluj_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void buttonRate_Click(object sender, RoutedEventArgs e)
        {
            if (verification())
            {
                Client klient;
                if ((klient=vm.ClientRepository.ClientsWithPesel(textBoxPESEL.Text)) != null)
                {
                    IList<Reservation> rezerwacje;
                    if ((rezerwacje = vm.ReservationsRepository.ReservationsOfVehicleByClient(klient, vm.SelectedVehicle)).Count>0)
                    {
                        if (rezerwacje.Where(x => x.Vehicle.Name == vm.SelectedVehicle.Name).ToList().Count >= 1)
                        {
                            if (rezerwacje.Where(x => x.Vehicle.Name == vm.SelectedVehicle.Name).ToList().First().Rated != true)
                            {
                                Reservation r = rezerwacje.Where(x => x.Vehicle.Name == vm.SelectedVehicle.Name).ToList().First();
                                vm.ReservationsRepository.RateReservation(r, rating.Value.Value);
                                vm.GetList();
                                MessageBox.Show("Ocena została dodana!");
                                Close();
                            }
                            else MessageBox.Show("Nie można dwa razy dodać oceny!");
                        }
                        else MessageBox.Show("Nie wypożyczał/a pan/pani tego pojazdu wcześniej.");
                    }
                    else MessageBox.Show("Nie ma pan/pani żadnych rezerwacji tego pojazdu w historii, nie może pan ocenić pojazdu.");
                }
                else MessageBox.Show("Nie mamy pani/pana w bazie, nie może pan dodać oceny.");                   
            }
        }
        private bool verification()
        {
            if(textBoxImie.Text=="")
            {
                MessageBox.Show("Imię nie może być puste.");
                return false;
            }
            if(textBoxNazwisko.Text=="")
            {
                MessageBox.Show("Nazwisko nie może być puste");
                return false;
            }
            if(!textBoxPESEL.Text.All(char.IsDigit) || textBoxPESEL.Text.Length!=11)
            {
                MessageBox.Show("PESEL powinien składać się jedynie z liczb i zawierać 11 znaków.");
                return false;
            }
            if(rating.Value==null)
            {
                MessageBox.Show("Wybierz poprawną ocenę.");
                return false;
            }
            return true;
        }
    }
}
