namespace Lexicon_AB_MiniProject_Asset_Tracking_1
{
    internal class Asset
    {

        public Asset(string electronic, int lifespan, string office, string currency, double localprice)
        {

            Electronic = electronic;
            Lifespan = lifespan;
            Office = office;
            Currency = currency;
            LocalPrice = localprice;
        }



        public string Electronic { get; set; }
        public int Lifespan { get; set; }

        public string Office { get; set; }

        public string Currency { get; set; }

        public double LocalPrice { get; set; }


    }
}
