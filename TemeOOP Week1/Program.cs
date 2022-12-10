

using TemeOOP_Week1;

Product product = new Product("Apple", 0.99f, 10);

Console.WriteLine(product.GetName()); 
Console.WriteLine(product.GetPrice()); 
Console.WriteLine(product.GetQuantity()); 

product.SetName("Orange");
product.SetPrice(1.49f);
product.SetQuantity(20);

Console.WriteLine(product.GetName()); 
Console.WriteLine(product.GetPrice()); 
Console.WriteLine(product.GetQuantity()); 