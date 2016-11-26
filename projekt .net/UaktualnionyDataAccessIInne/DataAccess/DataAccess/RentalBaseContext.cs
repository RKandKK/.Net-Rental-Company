using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DataAccess
{
    public class RentalBaseContext : DbContext
    {
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        public RentalBaseContext() : base("Rent a wheel")
        {
           //Database.SetInitializer<RentalBaseContext>(new DropCreateDatabaseIfModelChanges<RentalBaseContext>());
        }

        public void AddClient(Client client)
        {
            Clients.Add(client);
            //SaveChanges();
        }


        public void CreateDatabase()
        {
            AddClient(new Client("Slawek", "Kowalkiewicz"));
            AddClient(new Client("Dawid", "Stelmach"));
            AddClient(new Client("David", "Drzewo"));
            AddClient(new Client("Wladyslaw", "Drzewo"));
         
        }

        public List<string> klienci()
        {
            List<string> temp = new List<string>();
            foreach (var k in Clients)
            {
                temp.Add(k.Name);
            }
            return temp;
        }


    }
}
