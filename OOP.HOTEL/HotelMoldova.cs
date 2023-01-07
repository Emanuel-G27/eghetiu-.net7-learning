using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.HOTEL
{
    internal class HotelMoldova : Hotel
    {
      
        public HotelMoldova(int numberOfEmployee, int numberOfRooms)
        {
            this.NumberOfEmployee = numberOfEmployee;
            this.NumberOfRooms = numberOfRooms;
        }

        public override string GetHotelName()
        {
            return "Hotel Moldova";
        }

        public override string GetLocation()
        {
            return "Located in Downtown Barlad";
        }

        public HotelMoldova()
        {
            County = County.Vaslui;
        }
    }
}
