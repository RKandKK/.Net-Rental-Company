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
    public class UserRepository : Repository
    {
        private DbSet<User> UsersDbSet;

        public UserRepository(DbSet<User> dbSet, RentalBaseContext rbc) : base(rbc)
        {
            UsersDbSet = dbSet;
        }



        /// <summary> Remove User from database </summary> 
        private void RemoveUser(User User)
        {
            UsersDbSet.Remove(User);
            RentalBase.SaveChanges();

        }

        /// <summary> Remove User with this pesel from database </summary> 
        public void RemoveUser(string pesel)
        {
            User User = UsersWithPesel(pesel);
            if (User != null)
                RemoveUser(User);

        }


        /// <summary> Create User and add to database </summary> 
        public void AddUser(string name, string surname, string pesel)
        {
            if(!IsUserInDatabase(pesel))
            {
                UsersDbSet.Add(new User() { Name = name, Surname = surname, Pesel = pesel });
                RentalBase.SaveChanges();
            }
            
        }

        /// <summary> Add User to database </summary> 
        public void AddUser(User newUser)
        {
            AddUser(newUser.Name, newUser.Surname, newUser.Pesel);
        }

        /// <summary> Returns User with this pesel or null </summary> 
        public User UsersWithPesel(string pesel)
        {
            var User = UsersDbSet.Where(c => c.Pesel == pesel).ToList();
            if (User.Count == 0)
                return null;

            return User.First();
        }

        /// <summary> If User with this name and surname in database </summary> 
        public bool IsUserInDatabase(string name, string surname)
        {
            return UsersDbSet.Count(c => c.Name == name && c.Surname == surname) > 0;
        }
        /// <summary> If User with this pesel in database </summary> 
        public bool IsUserInDatabase(string pesel)
        {
            return UsersDbSet.Count(c => c.Pesel == pesel) > 0;
        }

    }
}
