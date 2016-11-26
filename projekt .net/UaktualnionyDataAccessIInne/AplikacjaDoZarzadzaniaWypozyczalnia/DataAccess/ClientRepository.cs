using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Domain;

namespace DataAccess
{
    public class ClientRepository : Repository
    {
        private DbSet<Client> ClientsDbSet;

        public ClientRepository(DbSet<Client> dbSet, RentalBaseContext rbc) : base(rbc)
        {
            ClientsDbSet = dbSet;
        }



        /// <summary> Remove client from database </summary> 
        private void RemoveClient(Client client)
        {
            ClientsDbSet.Remove(client);
            RentalBase.SaveChanges();

        }

        /// <summary> Remove client with this pesel from database </summary> 
        public void RemoveClient(string pesel)
        {
            Client client = ClientsWithPesel(pesel);
            if (client != null)
                RemoveClient(client);

        }


        /// <summary> Create client and add to database </summary> 
        public void AddClient(string name, string surname, string pesel)
        {
            if(!IsClientInDatabase(pesel))
            {
                ClientsDbSet.Add(new Client() { Name = name, Surname = surname, Pesel = pesel });
                RentalBase.SaveChanges();
            }
            
        }

        /// <summary> Add client to database </summary> 
        public void AddClient(Client newClient)
        {
            AddClient(newClient.Name, newClient.Surname, newClient.Pesel);
        }

        /// <summary> Returns client with this pesel or null </summary> 
        public Client ClientsWithPesel(string pesel)
        {
            var client = ClientsDbSet.Where(c => c.Pesel == pesel).ToList();
            if (client.Count == 0)
                return null;

            return client.First();
        }

        /// <summary> If client with this name and surname in database </summary> 
        public bool IsClientInDatabase(string name, string surname)
        {
            return ClientsDbSet.Count(c => c.Name == name && c.Surname == surname) > 0;
        }
        /// <summary> If client with this pesel in database </summary> 
        public bool IsClientInDatabase(string pesel)
        {
            return ClientsDbSet.Count(c => c.Pesel == pesel) > 0;
        }

    }
}
