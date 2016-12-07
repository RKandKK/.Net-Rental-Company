using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Domain;
using DataAccess;
using System.Timers;

namespace AplikacjaDoZarzadzaniaWypozyczalnia
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ViewModel vm;        
        public MainWindow()
        {

                var db = new RentalBaseContext();
                vm = new ViewModel(db) { CurrentWindow = this };
                this.DataContext = vm;

                InitializeComponent();
        }

        private void listView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //nie wiem jak to zrobić inaczej, żeby było ,,ładnie"
            vm.ListDoubleClickF();

        }
        private void SearchValueChanged(object sender, RoutedEventArgs e)
        {
            vm.GetList();
        }
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            Application.Current.Shutdown();
        }

        private void ZalogujButton_OnClick(object sender, RoutedEventArgs e)
        {
            LoginWindow lw = new LoginWindow();
            lw.Show();
        }

        private void panelButton_Click(object sender, RoutedEventArgs e)
        {
            UserPanel up = new UserPanel();
            up.Show();
        }
    }
}
