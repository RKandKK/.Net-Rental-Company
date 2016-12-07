using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using Domain;
using DataAccess;
using System.Windows.Input;
using AplikacjaDoZarzadzaniaWypozyczalnia.Classes;
using System.Windows;

namespace AplikacjaDoZarzadzaniaWypozyczalnia
{
    public class ViewModel : INotifyPropertyChanged
    {
        public ViewModel(RentalBaseContext rbc)
        {
            VehicleRepository = rbc.VehicleRepository;
            UserRepository = rbc.UserRepository;
            ReservationsRepository = rbc.ReservationRepository;
            SearchOptions = new SearchOptions(VehicleRepository);
            OpenAddWindow = new DelegateCommand(x => OpenAddWindowF());
            GetList();                      
        }
        #region propertychanged
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        #endregion
        #region properties
        private ObservableCollection<Vehicle> _vehicles { get; set; }

        public ObservableCollection<Vehicle> Vehicles
        {
            get { return _vehicles; }
            set
            {
                _vehicles = value;
                OnPropertyChanged("_vehicles");
            }
        }
        
        public SearchOptions SearchOptions { get; set; }

        private Vehicle _selectedVehicle;
        public Vehicle SelectedVehicle
        {
            get { return _selectedVehicle; }
            set
            {
                _selectedVehicle = value;
                OnPropertyChanged("SelectedVehicle");
            }
        }
        public Window CurrentWindow { get; set; }
        #endregion
        #region repos
        public ReservationsRepository ReservationsRepository { get; set; }

        public UserRepository UserRepository { get; set; }

        public VehicleRepository VehicleRepository { get; set; }
        #endregion
        #region commands
        public ICommand OpenAddWindow { get; set; }
        #endregion       
        #region methods
        public void GetList()
        {
            Vehicles = new ObservableCollection<Vehicle>(SearchOptions.Vehicles());
            OnPropertyChanged("Vehicles");
        }               
        public void ListDoubleClickF()
        {
            if (SelectedVehicle != null)
            {
                ReservationWindow RV = new ReservationWindow(this);
                RV.ShowDialog();
            }
        }
        public void OpenAddWindowF()
        {
            AddVehicleWindow ADW = new AddVehicleWindow(this);
            ADW.ShowDialog();
        }
        #endregion
    }
}
