namespace Midterm_Store
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("GoTo1", typeof(NewPage1));
            Routing.RegisterRoute("GoTo2", typeof(NewPage2));
            Routing.RegisterRoute("GoTo3", typeof(NewPage3));
            Routing.RegisterRoute("GoTo4", typeof(NewPage4));
            Routing.RegisterRoute("GoToCheckout", typeof(NewPage5));

        }
    }
}
