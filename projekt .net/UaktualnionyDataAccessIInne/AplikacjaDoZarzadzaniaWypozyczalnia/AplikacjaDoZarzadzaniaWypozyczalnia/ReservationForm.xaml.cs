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
using DataAccess;

namespace AplikacjaDoZarzadzaniaWypozyczalnia
{
    /// <summary>
    /// Interaction logic for ReservationForm.xaml
    /// </summary>
    public partial class ReservationForm : Window
    {
        private ViewModel vm;
        public ReservationForm(ViewModel vm)
        {
            this.vm = vm;
            InitializeComponent();
        }
            
        private void buttonRezerwuj_Click(object sender, RoutedEventArgs e)
        {
            if (verification())
            {
                if (!vm.ReservationsRepository.IsVehicleOccupiedInPeriodOfTime(vm.SelectedVehicle, SincePicker.Value.Value, TillPicker.Value.Value))
                {
                    
                    if (TillPicker.Value.Value <= SincePicker.Value.Value || (int)TillPicker.Value.Value.Subtract(SincePicker.Value.Value).TotalHours < 1)
                        MessageBox.Show("Rezerwacja musi być wykonana na co najmniej jedną godzinę!");
                    else
                    {
                        MessageBox.Show(String.Format("Dokonano zamówienia na nazwisko {0} {1}, PESEL: {2}. Koszt: {3}zł", textBoxImie.Text,
                        textBoxNazwisko.Text, textBoxPESEL.Text, (int)TillPicker.Value.Value.Subtract(SincePicker.Value.Value).TotalHours * vm.SelectedVehicle.PricePerHour));

                        if (vm.UserRepository.IsUserInDatabase(textBoxPESEL.Text))
                        {
                            vm.ReservationsRepository.AddReservation(vm.SelectedVehicle, vm.UserRepository.UsersWithPesel(textBoxPESEL.Text), SincePicker.Value.Value, TillPicker.Value.Value);
                        }
                        else
                        {
                            vm.UserRepository.AddUser(textBoxImie.Text, textBoxNazwisko.Text, textBoxPESEL.Text);
                            vm.ReservationsRepository.AddReservation(vm.SelectedVehicle, vm.UserRepository.UsersWithPesel(textBoxPESEL.Text), SincePicker.Value.Value, TillPicker.Value.Value);
                        }
                        Close();
                    }
                }
                else MessageBox.Show("Przykro nam, ale ten pojazd jest już zarezerwowany.");
            }
            
        }

        private void buttonAnuluj_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private bool verification()
        {            
            if(textBoxImie.Text == "")
            {
                MessageBox.Show("Imię nie może być puste.");
                return false;
            }
            if(textBoxNazwisko.Text == "")
            {
                MessageBox.Show("Nazwisko nie może być puste.");
                return false;
            }
            if(SincePicker.Value == null)
            {
                MessageBox.Show("Podaj od kiedy chcesz wypożyczyć pojazd.");
                return false;
            }
            if(TillPicker.Value == null)
            {
                MessageBox.Show("Podaj do kiedy chcesz wypożyczyć pojazd.");
                return false;
            }
            if(!textBoxPESEL.Text.All(char.IsDigit) || textBoxPESEL.Text.Length!=11)
            {
                MessageBox.Show("Pesel powinien mieć długość 11 znaków i składać się jedynie z cyfr.");
                return false;
            }
            if(SincePicker.Value.Value>=TillPicker.Value.Value || SincePicker.Value.Value.Day<DateTime.Now.Day || TillPicker.Value.Value.Day<DateTime.Now.Day)
            {
                MessageBox.Show("Data ''od'' nie może być później niż data ''do''. Zamówienia nie mogą zaczynać się w przeszłości.");
                return false;
            }
            return true;
        }
    }
}
