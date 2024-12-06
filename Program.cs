


using Lexicon_AB_MiniProject_Asset_Tracking_1;

Laptop electronic1 = new Laptop("Laptop Computer", 3, "SWEDEN", "Macbook", "", new DateTime(2022, 04, 05), 1400, "SEK", 15224.86);
Laptop electronic2 = new Laptop("Laptop Computer", 3, "NORWAY", "Asus", "", new DateTime(2024, 01, 01), 1320, "NOK", 14615.68);
Laptop electronic3 = new Laptop("Laptop Computer", 3, "DENMARK", "Lenovo", "", new DateTime(2023, 01, 01), 1100, "DKK", 7756.3);
Mobile electronic4 = new Mobile("Mobile Phone", 3, "SWEDEN", "Iphone", "", new DateTime(2019, 01, 01), 750, "SEK", 8156.175);
Mobile electronic5 = new Mobile("Mobile Phone", 3, "DENMARK", "Samsung", "", new DateTime(2018, 01, 01), 660, "DKK", 4653.858);
Mobile electronic6 = new Mobile("Mobile Phone", 3, "SWEDEN", "Nokia", "", new DateTime(2021, 01, 01), 310, "SEK", 3371.219);

Laptop laptop1 = new Laptop("Laptop Computer", 0, "NORWAY", "DELL", "", new DateTime(2011, 01, 01), 1500, "NOK", 16608.6);

//Console.WriteLine(electronic1.Electronic + " " + electronic1.Lifespan + " " + electronic1.Brand + " " + electronic1.Model + " " + electronic1.PurchaseDate + " " + electronic1.Price);
List<Electronic> assets = new List<Electronic>();

assets.Add(electronic1);
assets.Add(electronic2);
assets.Add(electronic3);
assets.Add(electronic4);
assets.Add(electronic5);
assets.Add(electronic6);
assets.Add(laptop1);

var sortedAsset = assets.OrderBy(asset => asset.Office).ThenBy(asset => asset.PurchaseDate);

foreach (var asset in sortedAsset)
{
    Console.ResetColor();
    if (DateTime.Now.AddMonths(-36 + 3) > asset.PurchaseDate)
    {
        Console.ForegroundColor = ConsoleColor.Red;

    }
    else if (DateTime.Now.AddMonths(-36 + 6) > asset.PurchaseDate)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
    }

    Console.WriteLine(asset.Electronic + " " + asset.Brand + " " + asset.PurchaseDate.ToString("yyyy-MM-dd") + " " + asset.Office + " USD" + asset.Price + " " + asset.Currency + " " + asset.LocalPrice);


}


Console.ResetColor();

// userInput and outputs

while (true)
{

    string electronic = "Laptop Computer";
    string electronicTwo = "Mobile Phone";
    int lifespan = 3;
    string office = null;
    string brand = null;
    string model = null;
    DateTime date = DateTime.Now;
    int price = 0;
    string currency = null;
    double localprice = 0;


    Console.WriteLine("\nMenu:");
    Console.WriteLine("1. Add a Laptop");
    Console.WriteLine("2. Add a Mobile");
    Console.Write("Enter your choice: ");
    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            Console.WriteLine("Enter your office of choice");
            electronic = Console.ReadLine();
            Laptop laptop = new Laptop(electronicTwo, lifespan, office, brand, model, date, price, currency, localprice);
            assets.Add(laptop);
            break;
        case "2":
            Console.WriteLine("Enter your office of choice");
            electronicTwo= Console.ReadLine();
            Mobile mobile = new Mobile(electronicTwo, lifespan, office, brand, model, date, price, currency, localprice);
            assets.Add(mobile);
            break;
        case "3":
            return;

    }
   
    foreach (var asset in sortedAsset)
    {
        Console.ResetColor();
        if (DateTime.Now.AddMonths(-36 + 3) > asset.PurchaseDate)
        {
            Console.ForegroundColor = ConsoleColor.Red;

        }
        else if (DateTime.Now.AddMonths(-36 + 6) > asset.PurchaseDate)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
        }

        Console.WriteLine(asset.Electronic + " " + asset.Brand + " " + asset.PurchaseDate.ToString("yyyy-MM-dd") + " " + asset.Office + " USD" + asset.Price + " " + asset.Currency + " " + asset.LocalPrice);


    }
        Console.ResetColor();


}





