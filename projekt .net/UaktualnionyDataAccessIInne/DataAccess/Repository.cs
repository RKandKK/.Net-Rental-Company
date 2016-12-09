using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public abstract class Repository
    {
        protected RentalBaseContext RentalBase { get; private set; }
        public Repository(RentalBaseContext rbc)
        {
            RentalBase = rbc;
        }
    }
}
