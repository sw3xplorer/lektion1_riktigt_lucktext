string name;
string car_brand;
string color;
string problem;
string date;
Console.WriteLine("What's your name?");
name = Console.ReadLine();
Console.WriteLine("Name a car brand.");
car_brand = Console.ReadLine();
Console.WriteLine("Name a color.");
color = Console.ReadLine();
Console.WriteLine("Name a mechanical problem.");
problem = Console.ReadLine();
Console.WriteLine("Name a date.");
date = Console.ReadLine();
//Console.WriteLine($"{name}"); template för variabler i text

Console.WriteLine($"Hello {name}.");
Console.WriteLine($"We're writing thsi e-mail to inform you about your {color} {car_brand} which you sent to our service.");
Console.WriteLine("Our truck was supposed to arrive at your house today");
Console.WriteLine($"but the truck suffered from a {problem} and the car got damaged.");
Console.WriteLine($"The car will instead be delivered to you on {date}. Thank you for your patiance.");
Console.ReadLine();