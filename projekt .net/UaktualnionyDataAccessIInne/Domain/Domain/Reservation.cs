using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Reservation : Entity
    {

        public bool Rated { get; private set; }
        
        public virtual Vehicle Vehicle { get; private set; }

        public virtual User User { get; private set; }

        public int Cost { get; private set; } // of whole reservation

        public DateTime Since { get; private set; } // time since reservation starts
        public DateTime Till { get; private set; } //time till reservation expires

        public Reservation(Vehicle vehicle, User User, DateTime since, DateTime till)
        {
            Vehicle = vehicle;
            User = User;
            Since = since;
            Till = till;

            Cost = ReservationCost();

            Rated = false;
        }
        public Reservation() { }

        public int ReservationCost()
        {
            return Vehicle.PricePerHour * ReservationDuration();
        }

        // how many hours left
        public int ReservationLeft(DateTime currentTime)
        {
            return (int)(Till - currentTime).TotalHours + 1;
        }

        // in hours (full hours) 
        public int ReservationDuration()
        {
            return (int)(Till - Since).TotalHours + 1; // +1 ktos rezerwuje na 45 min to nadal placi za 1h, wiec zaokraglam do gory
        }


        // rate reservation
        public void RateReservation(double newRating)
        {
            if (!Rated)
            {
                Rated = true;
                Vehicle.AddRating(newRating);
            }
        }
    }
}
