using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class User : Entity
    {
        public User() { }

        public User(string name, string surname)
        {
            Name = name;
            Surname = surname;
            Login = null;
            Password = null;
        }

        public User(string name, string surname, string login, string password)
        {
            Name = name;
            Surname = surname;
            Login = login;
            Password = password;
        }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        private bool IsAdministrator { get; set; }

    }
}
