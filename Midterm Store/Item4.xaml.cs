namespace Midterm_Store;

public partial class NewPage4 : ContentPage
{
	public NewPage4()
	{
		InitializeComponent();
	}
    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }
}