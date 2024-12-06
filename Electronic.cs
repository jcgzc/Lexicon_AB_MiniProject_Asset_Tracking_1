namespace Lexicon_AB_MiniProject_Asset_Tracking_1
{
    internal class Electronic : Asset
    {

        public Electronic(string electronic, int lifespan, string office, string brand, string model, DateTime purchasedate, int price, string currency, double localprice) : base(electronic, lifespan, office, currency, localprice)
        {


            Brand = brand;
            Model = model;
            PurchaseDate = purchasedate;
            Price = price;
            


        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int Price { get; set; }




    }
}
