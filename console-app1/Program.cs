string name = string.Empty;
int age = 0;
bool status = false;
DateTime currentDate = DateTime.Now;
float price = 0.0f;
decimal balance = 0.0m;

Console.WriteLine("Enter your name:");
name = Console.ReadLine() ?? string.Empty;

Console.WriteLine("Enter your age:");
age = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Enter your status (true/false):");
status = bool.Parse(Console.ReadLine() ?? "false");

Console.WriteLine("Enter the current date (yyyy-MM-dd):");
currentDate = DateTime.Parse(Console.ReadLine() ?? DateTime.Now.ToString("yyyy-MM-dd"));

Console.WriteLine("Enter the price:");
price = float.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Enter the balance:");
balance = decimal.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Write results:");
Console.WriteLine($"Name: {name}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Status: {status}");
Console.WriteLine($"Current Date: {currentDate}");
Console.WriteLine($"Price: {price}");
Console.WriteLine($"Balance: {balance}");