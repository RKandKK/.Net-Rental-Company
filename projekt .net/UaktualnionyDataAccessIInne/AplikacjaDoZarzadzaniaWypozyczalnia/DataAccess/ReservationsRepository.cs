using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Domain;

namespace DataAccess
{
    public class ReservationsRepository : Repository
    {
        private DbSet<Reservation> ReservationsDbSet;

        public ReservationsRepository(DbSet<Reservation> dbSet, RentalBaseContext rbc) : base(rbc)
        {
            ReservationsDbSet = dbSet;
        }

        // main method for removing reservations
        private void RemoveReservation(Reservation r)
        {
            ReservationsDbSet.Remove(r);
            RentalBase.SaveChanges();
        }

        /// <summary> Removes last reservation of this vehicle by this User</summary> 
        public void RemoveReservation(User c, Vehicle v)
        {
            var reservations = ReservationsOfVehicleByUser(c, v).ToList();
            reservations.Sort((r1, r2) => r1.Till.Hour - r2.Till.Hour);
            Reservation lastReservation = reservations.First();
            if (lastReservation != null)
            {
                RemoveReservation(lastReservation);
            }
        }

        // main method for adding reservations
        private void AddReservation(Reservation reservation)
        {
            ReservationsDbSet.Add(reservation);
            RentalBase.SaveChanges();
        }

        /// <summary> Returns true (and add vehicle) if it is not occupied</summary> 
        public bool AddReservation(Vehicle v, User c, DateTime since, DateTime till)
        {
            if (IsVehicleOccupiedInPeriodOfTime(v, since, till)) // occupied in that time
                return false;
            Reservation reservation = new Reservation(v, c, since, till);

            AddReservation(reservation);
            return true;
        }
        public void RemoveAllReservationsWithVehicle(Vehicle v)
        {
            List<Reservation> reservations = ReservationsDbSet.Where(r => r.Vehicle.Name == v.Name).ToList();
            ReservationsDbSet.RemoveRange(reservations);
        }
        /// <summary> All reservations ever made (in database) </summary> 
        public IList<Reservation> AllReservationsEver()
        {
            return ReservationsDbSet.ToList();
        }

        /// <summary> All reservations in time </summary> 
        public IList<Reservation> ActiveReservations(DateTime time)
        {
            return ReservationsDbSet.Where(r => r.Till > time && r.Since < time).ToList();
        }


        /// <summary> All reservations of Vehicle by this User </summary> 
        public IList<Reservation> ReservationsOfVehicleByUser(User c, Vehicle v)
        {
            return ReservationsDbSet.Where(r => r.User.Pesel == c.Pesel && r.Vehicle.Name == v.Name).ToList();
        }

        /// <summary> All reservations done by this User (expired reservations too) </summary> 
        public IList<Reservation> ReservationsOfUser(User c)
        {
            return ReservationsDbSet.Where(r => r.User == c).ToList();
        }

        /// <summary> All reservations done by this User (expired reservations too) </summary> 
        public IList<Reservation> ReservationsOfUser(string pesel)
        {
            return ReservationsDbSet.Where(r => r.User.Pesel == pesel).ToList();
        }

        /// <summary> How many reservations by User with this pesel in database </summary> 
        public int AmountOfReservationsOfUser(string pesel)
        {
            return ReservationsOfUser(pesel).Count;
        }

        /// <summary> How many reservations by this User </summary> 
        public int AmountOfReservationsOfUser(User c)
        {
            return ReservationsOfUser(c).Count;
        }

        /// <summary> Is User with this pesel in database </summary> 
        public bool IsUserInDatabase(string pesel)
        {
            return ReservationsOfUser(pesel).Count > 0;
        }

        /// <summary> Is this User  in database </summary> 
        public bool IsUserInDatabase(User c)
        {
            return ReservationsOfUser(c).Count > 0;
        }

        /// <summary> How many User spent on all reservations (total) </summary> 
        public int AllUserReservationsCost(User c)
        {
            return ReservationsOfUser(c).Sum(r => r.Cost);
        }

        /// <summary> How many User with this pesel spent on all reservations (total)  </summary> 
        public int AllUserReservationsCost(string pesel)
        {
            return ReservationsOfUser(pesel).Sum(r => r.Cost);
        }

        /// <summary> All reservations of vehicle (ever)  </summary> 
        public IList<Reservation> AllReservationsOfVehicle(Vehicle v)
        {
            return ReservationsDbSet.Where(r => r.Vehicle.Name == v.Name).ToList();
        }

        /// <summary> Reservation of vehicle in time  </summary> 
        public Reservation ReservationOfVehicleInTime(Vehicle v, DateTime time)
        {
            return ReservationsDbSet.Where(r => r.Vehicle == v && r.Since > time && r.Till < time).First();
        }

        /// <summary> Is vehicle occupied in this period of time  </summary> 
        public bool IsVehicleOccupiedInPeriodOfTime(Vehicle v, DateTime since, DateTime till)
        {
            var allReservations = AllReservationsOfVehicle(v);
            return ReservationsDbSet.Count(r => r.Vehicle.Name == v.Name && ((r.Till > since && r.Since < till)
            || (till > r.Since && since < r.Till))) > 0;

        }

        /// <summary> Is vehicle occupied in time </summary> 
        public bool IsVehicleOccupiedTime(Vehicle v, DateTime time)
        {
            return ReservationOfVehicleInTime(v, time) != null;
        }

        /// <summary> How many hours left vehicle is occupied, return 0 if not occupied </summary> 
        public int HoursLeftOccupied(Vehicle v, DateTime time)
        {
            Reservation res = ReservationOfVehicleInTime(v, time);
            if (res == null)
                return 0;

            return res.ReservationLeft(time);
        }
        public void RateReservation(Reservation rv, int value)
        {
            rv.RateReservation(value);
            RentalBase.SaveChanges();
        }

    }
}
