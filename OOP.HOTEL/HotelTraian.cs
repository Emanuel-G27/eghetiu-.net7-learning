using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace OOP.HOTEL
{
    internal class HotelTraian: Hotel
    {
        public string HystoricalValue { get; set; }

        public override string GetHotelName()
        {
            return "Hotel Traian";
        }

        public HotelTraian(int numberOfRooms, int numberOfEmployee, string hystoricalValue): base(numberOfRooms, numberOfEmployee)
        {
            HystoricalValue = hystoricalValue;
            County = County.Iasi;
        }

        public string GetHotelName(int numberOfStars)
        {
            
            
           if (numberOfStars < HotelStarsValidation.MinNumberOfStars || numberOfStars > HotelStarsValidation.MaxNumberOfStars)
           {
               throw new ArgumentException("Invalid number of stars!");
           }              
           return $"{GetHotelName()} has {numberOfStars} stars";
        }

    }
}
