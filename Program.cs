// See https://aka.ms/new-console-template for more information
List<Product> products = new List<Product>()
{
    new Product()
    { 
        Name = "Football", 
        Price = 15.00M, 
        Sold = false,
        StockDate = new DateTime(2022, 10, 20),
        ManufactureYear = 2010,
        Condition = 4.2
    },
    new Product() 
    { 
        Name = "Hockey Stick", 
        Price = 12.50M, 
        Sold = false,
        StockDate = new DateTime(2019, 8, 10),
        ManufactureYear = 2016,
        Condition = 3.4
    },
    new Product()
    {
        Name = "Soccer Ball",
        Price = 14.30M,
        Sold = false,
        StockDate = new DateTime(2012, 11, 23),
        ManufactureYear = 2011,
        Condition = 2.7
    },
    new Product()
    {
        Name = "Bulls Jersey",
        Price = 24.79M,
        Sold = true,
        StockDate = new DateTime(2019, 6, 12),
        ManufactureYear = 2016,
        Condition = 3.6
    },
    new Product() 
    {
        Name = "Nike Shoes",
        Price = 80.99M,
        Sold = false,
        StockDate = new DateTime(2023, 4, 14),
        ManufactureYear = 2018,
        Condition = 3.9
    },
    new Product()
    {
        Name = "Water Bottle",
        Price = 4.75M,
        Sold = false,
        StockDate = new DateTime(2016, 7, 28),
        ManufactureYear = 2014,
        Condition = 4.8
    }
};

string greeting = @"Welcome to Thrown for a Loop
Your one-stop shop for used sporting equipment";

Console.WriteLine(greeting);

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

Console.WriteLine(@$"You chose: 
{chosenProduct.Name}, which costs {chosenProduct.Price} dollars.
It is {now.Year - chosenProduct.ManufactureYear} years old. 
It has a condition rating of {chosenProduct.Condition}.
It {(chosenProduct.Sold ? "is not available." : $"has been in stock for {timeInStock.Days} days.")}");
