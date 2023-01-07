
namespace OOP.HOTEL
{
    internal abstract class Hotel: IHotel
    {
       
        private string invalidCountryErrorMessage = "Invalid County";

        
        public int NumberOfRooms { get; set; }

        public int NumberOfEmployee { get; set; }

        public County County { get; set; }

        public double NumberOfPrivateParkingLots
        {
            get
            {
                if (County == County.Iasi)
                {
                    return 20_000;
                }

                if(County == County.Vaslui)
                {
                    return 10_000;
                }
                
                throw new Exception(invalidCountryErrorMessage);
            }
        }

        
        public Hotel() { }

        public Hotel(int numberOfRooms, int numberOfEmployee)
        {
            this.NumberOfEmployee = numberOfEmployee;
            this.NumberOfRooms = numberOfRooms;
        }

        public void Details()
        {
            Console.WriteLine($"{GetHotelName()} is {GetLocation()} with {NumberOfPrivateParkingLots} parking lots , has {NumberOfEmployee} employees and {NumberOfRooms} rooms");
        }
      
        public abstract string GetHotelName();

        public virtual string GetLocation()
        {
            return "Located in Union Square";
        }
    }   
    
}
