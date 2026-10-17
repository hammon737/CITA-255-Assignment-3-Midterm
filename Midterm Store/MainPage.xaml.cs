
namespace Midterm_Store
{
    public partial class MainPage : ContentPage
    {
        List<string> rows = new List<string>();
        public MainPage()
        {
            InitializeComponent();
            
            for (int i = 0; i < Details.ProductTitle.Length; i++)
            {
                rows.Add($"{Details.ProductTitle[i]}");
            }
            productList.ItemsSource = rows;
        }

        

        private async void OnProductSelected(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.Count == 0)
                return;

            string picked = e.CurrentSelection[0].ToString();

            productList.SelectedItem = null;

            int index = rows.IndexOf(picked);
            await Shell.Current.GoToAsync($"item?index={index}");
        }
        
    }
}
