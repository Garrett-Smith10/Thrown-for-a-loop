// See https://aka.ms/new-console-template for more information
string greeting = @"Welcome to Thrown for a Loop

Your one-stop shop for used sporting equipment!";

Console.WriteLine(greeting);

List<Product> products = new List<Product>() 
{
    new Product()
    {
        Name = "Football",
        Price = 15,
        Sold = false,
        StockDate = new DateTime(2025 ,1 ,7),
        ManufactureYear = 2010,
        Time = DateTime.Now
    },
    new Product()
    {
        Name = "Hockey Stick",
        Price = 12,
        Sold = false,
        StockDate = new DateTime(2025 ,1 ,2),
        ManufactureYear = 2015,
        Time = DateTime.Now
    },
    new Product()
    {
        Name = "Soccer Ball",
        Price = 13,
        Sold = false,
        StockDate = new DateTime(2025 ,1 ,3),
        ManufactureYear = 2014,
        Time = DateTime.Now
    },
    new Product()
    {
        Name = "Basketball",
        Price = 11,
        Sold = false,
        StockDate = new DateTime(2025 ,1 ,4),
        ManufactureYear = 2013,
        Time = DateTime.Now
    },
    new Product()
    {
        Name = "Baseball Glove",
        Price = 16,
        Sold = false,
        StockDate = new DateTime(2025 ,1 ,5),
        ManufactureYear = 2012,
        Time = DateTime.Now
    },
    new Product()
    {
        Name = "Shin Guards",
        Price = 8,
        Sold = true,
        StockDate = new DateTime(2025 ,1 ,6),
        ManufactureYear = 2011,
        Time = DateTime.Now
    }
};
Console.WriteLine("Products:");

for (int i = 0; i < products.Count; i++)
{
    Console.WriteLine($"{i + 1}. {products[i].Name}");
}

Console.WriteLine("Please enter a product number: ");

int response = int.Parse(Console.ReadLine().Trim());

while (response > products.Count || response < 1)
{
    Console.WriteLine("Choose a number between 1 and 5!");
    response = int.Parse(Console.ReadLine().Trim());
}

Product chosenProduct = products[response -1];
DateTime now = DateTime.Now;
TimeSpan timeInStock = now - chosenProduct.StockDate;
Console.WriteLine(@$"You chose: {chosenProduct.Name}, which costs { chosenProduct.Price} dollars.
 It is {now.Year - chosenProduct.ManufactureYear} years old. 
 It {(chosenProduct.Sold ? "is not available " : $"has been in stock for {timeInStock.Days} days.")}");
