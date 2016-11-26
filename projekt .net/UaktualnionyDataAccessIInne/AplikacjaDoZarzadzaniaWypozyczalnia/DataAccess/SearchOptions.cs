using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DataAccess
{
    public sealed class SearchOptions
    {
        public VehicleRepository vr { get; set; }

        public bool quad { get; set; }
        public bool motorcycle { get; set; }

        public int maxconsumption { get; set; }
        public int minprice { get; set; }
        public int maxprice { get; set; }

        public SearchOptions(VehicleRepository vr)
        {
            this.vr = vr;
        }
        public IList<Vehicle> Vehicles()
        {
            List<Vehicle> returnList = new List<Vehicle>();
            if (quad && motorcycle) returnList = vr.VehicleDbSet.ToList();
            else if (quad) returnList.AddRange(vr.VehiclesOfType(VehicleType.Quad));
            else if (motorcycle) returnList.AddRange(vr.VehiclesOfType(VehicleType.Motorcycle));
            return returnList.Where(x=>x.FuelConsumption<=maxconsumption).Where(x=>x.PricePerHour<=maxprice && x.PricePerHour>=minprice).ToList();
        }
    }
}
