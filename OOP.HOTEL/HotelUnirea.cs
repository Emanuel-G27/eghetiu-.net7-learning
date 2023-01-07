using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.HOTEL
{
    internal class HotelUnirea : Hotel
    {
        public string InsidePool { get; set; }

        public override string GetHotelName()
        {
            return "Hotel Unirea";
        }

        public HotelUnirea(int numberOfRooms, int numberOfEmployee, string insidePool) : base(numberOfRooms, numberOfEmployee)
        {
            this.InsidePool = insidePool;
            County = County.Iasi;
        }

        public string GetHotelName(int numberOfStars)
        {
            if (numberOfStars < HotelStarsValidation.MinNumberOfStars
            || numberOfStars > HotelStarsValidation.MaxNumberOfStars)
            {
                throw new ArgumentException("Invalid number of stars!");
            }
            return $"{GetHotelName()} has {numberOfStars} stars";

        }
    }
}
