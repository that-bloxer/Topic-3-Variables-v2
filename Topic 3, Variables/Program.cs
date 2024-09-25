string name, eyes, teeth, hair, course, full_name;
int age, height, weight, room, grad_year;
double price;

name = "John Smith";
age = 35;     //not a lie
height = 74;  //inches
weight = 180; //lbs
eyes = "Brown";
teeth = "White";
hair = "Brown";
course = "Computer Science";
room = 29;
price = 2.99;
full_name = "Julian McGuire";
grad_year = 2027;

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Let's talk about " + name + ".");
Console.WriteLine("He's " + height + " inches tall.");
Console.WriteLine("He's " + weight + " pounds heavy.");
Console.WriteLine("Actually, that's not too heavy.");
Console.WriteLine("He's got " + eyes + " eyes and " + hair + " Hair.");
Console.WriteLine("His teeth are usually " + teeth + " depending on the coffee.");
Console.WriteLine("If I add " + age + ", " + height + ", and " + weight + " I get " + (age + height + weight) + ".");
Console.WriteLine();
Console.WriteLine("Press ENTER to continue.");
Console.ReadLine();
Console.WriteLine("Assignment");
Console.ReadLine();
Console.WriteLine("This is room # " + room + ".");
Console.WriteLine("The price is " + price + ".");
Console.WriteLine("I am learning a bit about " + course + "!");
Console.ReadLine();
Console.WriteLine("My name is " + full_name + " and I'll graduate in " + grad_year  + ".");
Console.ReadLine();
Console.WriteLine();