using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;


namespace DataAccess
{
    public class VehicleRepository : Repository
    {
        public DbSet<Vehicle> VehicleDbSet { get; private set; }
        public ReservationsRepository RRepository { get; private set; }

        public VehicleRepository(DbSet<Vehicle> dbSet, RentalBaseContext rbc) : base(rbc)
        {
            RRepository = rbc.ReservationRepository;
            VehicleDbSet = dbSet;
        }

        /// <summary> Add vehicle if there is no vehicle with this name already </summary> 
        public async void AddVehicle(Vehicle v)
        {
            if (!IsVehicleWithNameInDatabase(v.Name))
            {
                await Task.Run(()=>VehicleDbSet.Add(v));
                RentalBase.SaveChanges();
            }
        }

        /// <summary> Remove vehicle from database </summary> 
        public void RemoveVehicle(Vehicle v)
        {
            if (IsVehicleWithNameInDatabase(v.Name))
            {
                //oj jak tu by sie uow przydał :(((
                RRepository.RemoveAllReservationsWithVehicle(v);
                VehicleDbSet.Remove(v);
                RentalBase.SaveChanges();
            }
        }

        /// <summary> Vehicles of this type </summary> 
        public IList<Vehicle> VehiclesOfType(VehicleType vt)
        {
            return VehicleDbSet.Where(v => v.Type == vt).ToList();
        }

        /// <summary> Is vehicle with this name is already in database </summary> 
        public bool IsVehicleWithNameInDatabase(string name)
        {
            return VehicleDbSet.Count(v => v.Name == name) > 0;
        }

        /// <summary> Is this vehicle is already in database </summary> 
        public bool IsVehicleInDatabase(Vehicle v)
        {
            return VehicleDbSet.Contains(v);
        }

        /// <summary> Vehicles with price per hour between minPrice and maxPrice </summary> 
        public IList<Vehicle> VehiclesWithPrice(int maxPrice, int minPrice = 0)
        {
            return VehicleDbSet.Where(v => v.PricePerHour <= maxPrice && v.PricePerHour >= minPrice).ToList();
        }

        /// <summary> Vehicles with this driving licence </summary> 
        public IList<Vehicle> VehiclesWithDrivingLicence(DriversLicense dl)
        {
            return VehicleDbSet.Where(v => v.DriversLicense == dl).ToList();
        }

        /// <summary> Vehicles with lower fuel consumption than this </summary> 
        public IList<Vehicle> VehiclesWithFuelConsumption(double fuel)
        {
            return VehicleDbSet.Where(v => v.FuelConsumption <= fuel).ToList();
        }
        public void ChangePrice (Vehicle vh, int value)
        {
            VehicleDbSet.Where(v => v.Name == vh.Name).First().ChangePrice(value);
            RentalBase.SaveChanges();
        }
    }
}
