
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
            "Health Potion",
            "Love Potion",
            "Gravity Potion",
            "Sensory Enhancement Potion"
        ];

        private async void OnProductSelected(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.Count > 0)
            {
                string picked = e.CurrentSelection[0].ToString();

                productList.SelectedItem = null;

                if (picked == "Health Potion")
                {
                    await Shell.Current.GoToAsync("GoTo1");
                }
                if (picked == "Love Potion")
                {
                    await Shell.Current.GoToAsync("GoTo2");
                }
                if (picked == "Gravity Potion")
                {
                    await Shell.Current.GoToAsync("GoTo3");
                }
                if (picked == "Sensory Enhancement Potion")
                {
                    await Shell.Current.GoToAsync("GoTo4");
                }
            }
        }
        
    }
}
