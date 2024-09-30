// See https://aka.ms/new-console-template for more information
using ClassDemoE24Reflection.model;
using ClassDemoE24Reflection.Reflection;

Console.WriteLine("Hello, Reflection!");

IDrink drink1 = new Drink(1, "Kondi", "Sports");
Drink drink2 = new Drink(3, "Cola", "Opkvikkende");
IDrink drink3 = new Beer(10, "Tuborg Classic Zero", "Pilsner", 0.0);
Beer drink4 = new Beer(11, "Wiibroe", "Årgangsøl", 9.9);

Console.WriteLine(drink1);
Console.WriteLine(drink2);
Console.WriteLine(drink3);
Console.WriteLine(drink4);


InspectObjects io = new InspectObjects();
Console.WriteLine("Prøver drink1");
io.TryReflection(drink1);

Console.WriteLine("Prøver drink1");
io.TryReflection(drink2);

Console.WriteLine("Prøver drink3");
io.TryReflection(drink3);

Console.WriteLine("Prøver drink4");
io.TryReflection(drink4);
