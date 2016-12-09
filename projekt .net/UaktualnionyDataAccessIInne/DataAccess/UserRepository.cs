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

        /// <summary> Remove User with this login from database </summary> 
        public void RemoveUser(string login)
        {
            User User = UsersWithLogin(login);
            if (User != null)
                RemoveUser(User);

        }
       
        /// <summary> Create User and add to database </summary> 
        public void AddUser(string name, string surname, string login = null, string password = null)
        {
            if(!IsUserInDatabase(login))
            {
                UsersDbSet.Add(new User(name, surname, login, password) );
                RentalBase.SaveChanges();
            }
            
        }

        /// <summary> Add User to database </summary> 
        public void AddUser(User newUser)
        {
            AddUser(newUser.Name, newUser.Surname, newUser.Login, newUser.Password);
        }

        /// <summary> Returns User with this login or null </summary> 
        public User UsersWithLogin(string login)
        {
            var users = UsersDbSet.Where(c => c.Login == login).ToList();
            if (users.Count == 0)
                return null;

            return users.First();
        }

        /// <summary> If User with this name and surname in database </summary> 
        public bool IsUserInDatabase(string name, string surname)
        {
            return UsersDbSet.Count(c => c.Name == name && c.Surname == surname) > 0;
        }
        /// <summary> If User with this login in database </summary> 
        public bool IsUserInDatabase(string login)
        {
            return UsersDbSet.Count(c => c.Login == login) > 0;
        }

    }
}
