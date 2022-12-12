


using TemeOOP2;

Animal animal = new Animal("Max", "Dog", "Labrador Retriever", 2, "Yellow", 75 , true );

Console.WriteLine(animal.GetName()); 
Console.WriteLine(animal.GetSpecies()); 
Console.WriteLine(animal.GetBreed());
Console.WriteLine(animal.GetAge()); 
Console.WriteLine(animal.GetColor()); 
Console.WriteLine(animal.GetWeight()); 
Console.WriteLine(animal.IsSpayedOrNeutered()); 


animal.SetName("Buddy");
animal.SetSpecies("Cat");
animal.SetBreed("Siamese");
animal.SetAge(5);
animal.SetColor("Gray");
animal.SetWeight(12);
animal.SetIsSpayedOrNeutered(false);

Console.WriteLine();

Console.WriteLine(animal.GetName()); 
Console.WriteLine(animal.GetSpecies()); 
Console.WriteLine(animal.GetBreed()); 
Console.WriteLine(animal.GetAge()); 
Console.WriteLine(animal.GetColor());
Console.WriteLine(animal.GetWeight()); 
Console.WriteLine(animal.IsSpayedOrNeutered());