namespace PPUke4Marija
{
    public class Program
    {
        public static void Main(string[] args)
        {

            // Set up a store:

            //
            // Varer
            // Ansatte
            // Lager

            /* User:
            // Inventory & Currency
            */
            var functions = new StoreSetup();
            var myStore = functions.CreateShop();

        }        
    }
}