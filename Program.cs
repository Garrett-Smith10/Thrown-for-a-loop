// See https://aka.ms/new-console-template for more information
List<Product> products = new List<Product>() 
{
    new Product()
    {
        Name = "Football",
        Price = 15.00M,
        Sold = false,
        StockDate = new DateTime(2025 ,1 ,7),
        ManufactureYear = 2010,
        Time = DateTime.Now,
        Condition = 4.2
    },
    new Product()
    {
        Name = "Hockey Stick",
        Price = 12.99M,
        Sold = false,
        StockDate = new DateTime(2025 ,1 ,2),
        ManufactureYear = 2015,
        Time = DateTime.Now,
        Condition = 3.2
    },
    new Product()
    {
        Name = "Soccer Ball",
        Price = 13.01M,
        Sold = false,
        StockDate = new DateTime(2025 ,1 ,3),
        ManufactureYear = 2014,
        Time = DateTime.Now,
        Condition = 2.2
    },
    new Product()
    {
        Name = "Basketball",
        Price = 11.50M,
        Sold = false,
        StockDate = new DateTime(2025 ,1 ,4),
        ManufactureYear = 2013,
        Time = DateTime.Now,
        Condition = 1.2
    },
    new Product()
    {
        Name = "Baseball Glove",
        Price = 16.55M,
        Sold = false,
        StockDate = new DateTime(2025 ,1 ,5),
        ManufactureYear = 2012,
        Time = DateTime.Now,
        Condition = 4.7
    },
    new Product()
    {
        Name = "Shin Guards",
        Price = 8.99M,
        Sold = true,
        StockDate = new DateTime(2025 ,1 ,6),
        ManufactureYear = 2011,
        Time = DateTime.Now,
        Condition = 3.5
    }
};
string greeting = @"Welcome to Thrown for a Loop

Your one-stop shop for used sporting equipment!";


Console.WriteLine(greeting);
string choice = null;
while (choice != "0")
{
    Console.WriteLine(@"Choose an option:
                        0. Exit
                        1. View All Products
                        2. View Product Details
                        3. View Latest Products");
    choice = Console.ReadLine();
    if (choice == "0")
    {
        Console.WriteLine("Goodbye!");
    }
    else if (choice == "1")
    {
        ListProducts();
    }
    else if (choice == "2")
    {
        ViewProductDetails();
    }
    else if (choice == "3")
    {
        ViewLatestProducts();
    }
}

 void ViewProductDetails()
 {
    ListProducts();

Product chosenProduct = null;

while (chosenProduct == null)
{
    Console.WriteLine("Please enter a product number: ");
    try
    {
    int response = int.Parse(Console.ReadLine().Trim());
    chosenProduct = products[response - 1];
    }
    catch (FormatException)
    {
    Console.WriteLine("Please type only integers!");
    }
    catch (ArgumentOutOfRangeException)
    {
    Console.WriteLine("Please choose an existing item only!");
    }
    catch (Exception ex)
    {
    Console.WriteLine(ex);
    Console.WriteLine("Do Better!");
    }
}

DateTime now = DateTime.Now;
TimeSpan timeInStock = now - chosenProduct.StockDate;
Console.WriteLine(@$"You chose: {chosenProduct.Name}, which costs { chosenProduct.Price} dollars.
 It is {now.Year - chosenProduct.ManufactureYear} years old. 
 It {(chosenProduct.Sold ? "is not available " : $"has been in stock for {timeInStock.Days} days.")}
 The Condition rating is {chosenProduct.Condition}/5.");
 }

 void ListProducts()
 {
    decimal totalValue = 0.0M;
    foreach (Product product in products)
    {
        if (!product.Sold)
        {
            totalValue += product.Price;
        }
    }
    Console.WriteLine($"Total inventory value: ${totalValue}");
    Console.WriteLine("Products:");
    for (int i = 0; i < products.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {products[i].Name}");
    }
 }

 void ViewLatestProducts()
{
    // create a new empty List to store the latest products
    List<Product> latestProducts = new List<Product>();
    // Calculate a DateTime 90 days in the past
    DateTime threeMonthsAgo = DateTime.Now - TimeSpan.FromDays(90);
    //loop through the products
    foreach (Product product in products)
    {
        //Add a product to latestProducts if it fits the criteria
        if (product.StockDate > threeMonthsAgo && !product.Sold)
        {
            latestProducts.Add(product);
        }
    }
    // print out the latest products to the console 
    for (int i = 0; i < latestProducts.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {latestProducts[i].Name}");
    }
}

