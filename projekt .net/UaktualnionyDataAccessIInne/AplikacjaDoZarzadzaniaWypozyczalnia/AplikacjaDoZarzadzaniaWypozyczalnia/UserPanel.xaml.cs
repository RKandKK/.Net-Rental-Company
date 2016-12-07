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
    /// Interaction logic for UserPanel.xaml
    /// </summary>
    public partial class UserPanel : Window
    {
        public UserPanel()
        {
            InitializeComponent();
            List<Reservation> list = new List<Reservation>();
            list.Add(new Reservation(
                new Vehicle() {Name = "Pojazd 1"}, 
                new User(), 
                new DateTime(2016,12,5),
                new DateTime(2016,12,6)));
            list.Add(new Reservation(
                new Vehicle() {Name = "Pojazd 2"},
                new User(), 
                new DateTime(2014,7,11),
                new DateTime(2014,7,12)));
            listView.ItemsSource = list;
        }
    }
}
