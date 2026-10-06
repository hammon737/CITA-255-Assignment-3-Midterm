
namespace Midterm_Store
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            productList.ItemsSource = products;
        }

        List<string> products =
        [
            "Item 1",
            "Item 2",
            "Item 3",
            "Item 4"
        ];

        private async void OnProductSelected(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.Count > 0)
            {
                string picked = e.CurrentSelection[0].ToString();

                productList.SelectedItem = null;

                if (picked == "Item 1")
                {
                    await Shell.Current.GoToAsync("GoTo1");
                }
                if (picked == "Item 2")
                {
                    await Shell.Current.GoToAsync("GoTo2");
                }
                if (picked == "Item 3")
                {
                    await Shell.Current.GoToAsync("GoTo3");
                }
                if (picked == "Item 4")
                {
                    await Shell.Current.GoToAsync("GoTo4");
                }
            }
        }
        
    }
}
