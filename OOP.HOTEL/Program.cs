


using OOP.HOTEL;

HotelTraian hotel1 = new HotelTraian(200, 40, "National Heritage");
Console.WriteLine(hotel1.GetHotelName());
Console.WriteLine(hotel1.GetHotelName(5));
Console.WriteLine(hotel1.GetLocation());
hotel1.Details();

Console.WriteLine();

HotelUnirea hotel2 = new HotelUnirea(150, 30, "Unirea Pool");
Console.WriteLine(hotel2.GetHotelName());
Console.WriteLine(hotel2.GetHotelName(4));
Console.WriteLine(hotel2.GetLocation());
hotel2.Details();


Console.WriteLine();

HotelMoldova hotel3 = new HotelMoldova();
HotelMoldova hotel4 = new HotelMoldova(10, 100);
Console.WriteLine(hotel3.GetHotelName());
Console.WriteLine(hotel3.GetLocation());
hotel4.Details();
Console.WriteLine();

RoumanianFoodMenu menu = new RoumanianFoodMenu();
Console.WriteLine(menu.GetFoodMenu());

Console.WriteLine();

EnglishFoodMenu menu1 = new EnglishFoodMenu();
Console.WriteLine(menu1.GetFoodMenu());
