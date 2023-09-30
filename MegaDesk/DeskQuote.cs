
namespace MegaDesk
{
    public class DeskQuote
    {
        // Constants
        private const decimal BasePrice = 200.0m;
        private const decimal PricePerDrawer = 50.0m;

        // Properties
        public string CustomerName { get; set; }
        public Desk Desk { get; set; }
        public int RushOrderDays { get; set; }
        public decimal Price { get; private set; }

        public DeskQuote(string customerName, Desk desk, int rushOrderDays)
        {
            CustomerName = customerName;
            Desk = desk;
            RushOrderDays = rushOrderDays;
            Price = CalculatePrice();
        }

        // Method to calculate the price
        private decimal CalculatePrice()
        {
            return BasePrice + (decimal)Desk.SurfaceMaterial + Desk.SurfaceArea + (PricePerDrawer * Desk.NumberOfDrawers) + CalculateRushOrderPrice();
        }

        private decimal CalculateRushOrderPrice()
        {
            if (RushOrderDays >= 3 && RushOrderDays < 5)
            {
                RushOrderDays = 3;
                return CalculateRushFee(Desk.SurfaceArea, 60, 70, 80);
            }
            else if (RushOrderDays >= 5 && RushOrderDays < 7)
            {
                RushOrderDays = 5;
                return CalculateRushFee(Desk.SurfaceArea, 40, 50, 60);
            }
            else if (RushOrderDays >= 7 && RushOrderDays < 14)
            {
                RushOrderDays = 7;
                return CalculateRushFee(Desk.SurfaceArea, 30, 35, 40);
            }
            else
            {
                RushOrderDays = 14;
                return 0.0m;
            }
        }

        private decimal CalculateRushFee(decimal surfaceArea, decimal smallSizeFee, decimal mediumSizeFee, decimal largeSizeFee)
        {
            if (surfaceArea < 1000)
            {
                return smallSizeFee;
            }
            else if (surfaceArea >= 1000 && surfaceArea <= 2000)
            {
                return mediumSizeFee;
            }
            else
            {
                return largeSizeFee;
            }
        }

    }
}
