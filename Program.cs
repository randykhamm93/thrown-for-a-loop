// See https://aka.ms/new-console-template for more information
List<Product> products = new List<Product>()
{
    new Product()
    { 
        Name = "Football", 
        Price = 15, 
        Sold = false,
        StockDate = new DateTime(2022, 10, 20),
        ManufactureYear = 2010
    },
    new Product() 
    { 
        Name = "Hockey Stick", 
        Price = 12, 
        Sold = false,
        StockDate = new DateTime(2019, 8, 10),
        ManufactureYear = 2016
    },
    new Product()
    {
        Name = "Soccer Ball",
        Price = 14,
        Sold = false,
        StockDate = new DateTime(2012, 11, 23),
        ManufactureYear = 2011
    },
    new Product()
    {
        Name = "Bulls Jersey",
        Price = 24,
        Sold = true,
        StockDate = new DateTime(2019, 6, 12),
        ManufactureYear = 2016
    },
    new Product() 
    {
        Name = "Nike Shoes",
        Price = 80,
        Sold = false,
        StockDate = new DateTime(2023, 4, 14),
        ManufactureYear = 2018
    },
    new Product()
    {
        Name = "Water Bottle",
        Price = 4,
        Sold = false,
        StockDate = new DateTime(2016, 7, 28),
        ManufactureYear = 2014
    }
};

string greeting = @"Welcome to Thrown for a Loop
Your one-stop shop for used sporting equipment";

Console.WriteLine(greeting);

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

DateTime now = DateTime.Now;
Product chosenProduct = products[response - 1];
TimeSpan timeInStock = now - chosenProduct.StockDate;
Console.WriteLine(@$"You chose: 
{chosenProduct.Name}, which costs {chosenProduct.Price} dollars.
It is {now.Year - chosenProduct.ManufactureYear} years old. 
It {(chosenProduct.Sold ? "is not available." : $"has been in stock for {timeInStock.Days} days.")}");
