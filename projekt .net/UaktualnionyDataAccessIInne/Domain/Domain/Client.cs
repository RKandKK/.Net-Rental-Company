﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Client : Entity
    {
        public Client() { }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Pesel { get; set; }

    }
}
