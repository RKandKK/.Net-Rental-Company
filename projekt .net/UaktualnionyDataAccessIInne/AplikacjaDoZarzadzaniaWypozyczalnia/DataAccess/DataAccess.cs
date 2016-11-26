using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using System.Windows.Media.Imaging;
using System.Drawing;

namespace DataAccess
{
    public class RentalBaseContext : DbContext
    {
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        public ClientRepository ClientRepository { get; private set; }
        public VehicleRepository VehicleRepository { get; private set; }
        public ReservationsRepository ReservationRepository { get; private set; }
        
        public RentalBaseContext() : base("Server=(LocalDB)\\MSSQLLocalDB;Initial Catalog=RentAWheelApplicationDB;Integrated Security=True")
        {


            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<RentalBaseContext>());
            ClientRepository = new ClientRepository(Clients,this);
            ReservationRepository = new ReservationsRepository(Reservations,this);
            VehicleRepository = new VehicleRepository(Vehicles, this);

            CreateDatabase();
        }

        private void CreateDatabase()
        {            
            
            Vehicle v1 = new Vehicle(VehicleType.Motorcycle, 60, 4, DriversLicense.B, "Motor Cf", 80, 4);

            Vehicle v2 = new Vehicle(VehicleType.Motorcycle, 80, 6, DriversLicense.A2, "Motor Fireweed", 120, 4);

            Vehicle v3 = new Vehicle(VehicleType.Motorcycle, 70, 3, DriversLicense.A2, "Honda Cb", 80, 3);

            Vehicle v4 = new Vehicle(VehicleType.Motorcycle, 120, 9, DriversLicense.A1, "Kawasaki H2", 200, 1);

            Vehicle v5 = new Vehicle(VehicleType.Motorcycle, 65, 6, DriversLicense.A2, "Kawasaki", 150, 1);

            Vehicle v6 = new Vehicle(VehicleType.Quad, 40, 5, DriversLicense.AM, "Bashan", 60, 15);

            Vehicle v7 = new Vehicle(VehicleType.Quad, 50, 4, DriversLicense.AM, "Konder", 70, 18);

            Vehicle v8 = new Vehicle(VehicleType.Quad, 70, 4, DriversLicense.AM, "Suzuki Z4", 80, 20);

            Vehicle v9 = new Vehicle(VehicleType.Quad, 60, 5, DriversLicense.AM, "Varia", 110, 12);

            Vehicle v10 = new Vehicle(VehicleType.Quad, 65, 7, DriversLicense.AM, "Yamaha", 75, 10);

            ImageConverter ic = new ImageConverter();

            v1.SetImage((byte[])ic.ConvertTo(new Bitmap("Images\\Motor CF.jpg"), typeof(byte[])));
            v2.SetImage((byte[])ic.ConvertTo(new Bitmap("Images\\Motor Fireweed.jpeg"), typeof(byte[])));
            v3.SetImage((byte[])ic.ConvertTo(new Bitmap("Images\\Motor Honda CB.jpg"), typeof(byte[])));
            v4.SetImage((byte[])ic.ConvertTo(new Bitmap("Images\\Motor Kawasaki H2.jpg"), typeof(byte[])));
            v5.SetImage((byte[])ic.ConvertTo(new Bitmap("Images\\Motor Kawasaki.jpg"), typeof(byte[])));
            v6.SetImage((byte[])ic.ConvertTo(new Bitmap("Images\\Quad Bashan.jpg"), typeof(byte[])));
            v7.SetImage((byte[])ic.ConvertTo(new Bitmap("Images\\Quad Kondor.jpg"), typeof(byte[])));
            v8.SetImage((byte[])ic.ConvertTo(new Bitmap("Images\\Quad Suzuki Z4.jpg"), typeof(byte[])));
            v9.SetImage((byte[])ic.ConvertTo(new Bitmap("Images\\Quad Varia 125.jpg"), typeof(byte[])));
            v10.SetImage((byte[])ic.ConvertTo(new Bitmap("Images\\Quad Yamaha.jpg"), typeof(byte[])));


            VehicleRepository.AddVehicle(v1);
            VehicleRepository.AddVehicle(v2);
            VehicleRepository.AddVehicle(v3);
            VehicleRepository.AddVehicle(v4);
            VehicleRepository.AddVehicle(v5);
            VehicleRepository.AddVehicle(v6);
            VehicleRepository.AddVehicle(v7);
            VehicleRepository.AddVehicle(v8);
            VehicleRepository.AddVehicle(v9);
            VehicleRepository.AddVehicle(v10);
        }
        public static byte[] ImageToByte(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }
        
    }
}
