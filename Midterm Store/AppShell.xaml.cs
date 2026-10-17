namespace Midterm_Store
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("GoToCheckout", typeof(NewPage5));
            Routing.RegisterRoute("item", typeof(ProductDetail));

        }
    }
}
