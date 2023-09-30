using System.Windows.Forms;

namespace MegaDesk
{
    public partial class DisplayQuote : Form
    {
        public DisplayQuote(DeskQuote deskQuote)
        {
            InitializeComponent();
            nameDisplay.Text = deskQuote.CustomerName;
            widthDisplay.Text = deskQuote.Desk.Width.ToString();
            depthDisplay.Text = deskQuote.Desk.Depth.ToString();
            drawerDisplay.Text = deskQuote.Desk.NumberOfDrawers.ToString();
            materialDisplay.Text = deskQuote.Desk.SurfaceMaterial.ToString();
            shippingDisplay.Text = deskQuote.RushOrderDays.ToString();
            priceDisplay.Text = deskQuote.Price.ToString() + "$";
        }
    }
}
