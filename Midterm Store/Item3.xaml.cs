namespace Midterm_Store;

public partial class NewPage3 : ContentPage
{
	public NewPage3()
	{
		InitializeComponent();
	}
    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }
}