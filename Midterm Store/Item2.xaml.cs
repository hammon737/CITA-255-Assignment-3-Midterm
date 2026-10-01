namespace Midterm_Store;

public partial class NewPage2 : ContentPage
{
	public NewPage2()
	{
		InitializeComponent();
	}
    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }
}