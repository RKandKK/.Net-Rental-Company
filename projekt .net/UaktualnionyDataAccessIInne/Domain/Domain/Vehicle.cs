using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.CompilerServices;

namespace Domain
{
    public class Vehicle : Entity
    {
        //Variables used to count rating
        private const double MAX_RATING = 5.0f;
        private int quantityOfRates = 0;

        //Search criteria:
        public VehicleType Type { get; set; } //
        public int PricePerHour { get; set; } //
        public double FuelConsumption { get; set; }
        public DriversLicense DriversLicense { get; set; }

        //Additional info
        public string Name { get; set; }
        public int Vmax { get; set; }
        public int TrunkCapacity { get; set; }
        public double Rating { get; set; } // [0,MAX_RATING]
        public byte[] Image { get; set; }

        public Vehicle()
        {

        }
        // no image
        public Vehicle(VehicleType vt, int price, double fuel, DriversLicense dl, string name, int vmax, int trunkcapacity)
        {
            Type = vt;
            PricePerHour = price;
            FuelConsumption = fuel;
            DriversLicense = dl;
            Name = name;
            Vmax = vmax;
            TrunkCapacity = trunkcapacity;

            Rating = 0;
            quantityOfRates = 0;

        }

        public void AddRating(double newRating)
        {
            // rating between [0,MAX_RATING]
            if (newRating > MAX_RATING)
                newRating = MAX_RATING;
            if (newRating < 0)
                newRating = 0;
            // rating between [0,MAX_RATING]

            double sum = Rating * quantityOfRates;

            sum += newRating;
            quantityOfRates++;

            Rating = sum / quantityOfRates;
        }

        public void SetImage(byte[] image)
        {
            Image = image;
        }

        public void ChangePrice(int value)
        {
            PricePerHour = value;
            OnPropertyChanged(nameof(PricePerHour));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public enum VehicleType
    {
        Quad,
        Motorcycle
    }

    public enum DriversLicense
    {
        AM,
        A,
        A1,
        A2,
        B1,
        B
    }
}