namespace Midterm_Store;

public partial class NewPage3 : ContentPage
{
	public NewPage3()
	{
		InitializeComponent();
	}
    void Ordered(object sender, EventArgs e)
    {

        if (double.TryParse(orderEntry.Text, out double outNumber))
        {
            if (outNumber > 0 && outNumber < 99)
            {
                resultLabel.Text = $"Added {outNumber}x Item 3 to your cart.";
            }
            else
            {
                DisplayAlertAsync("Hang on", "That number can't be ordered. Try again with a number between 1 and 99.", "Ok");
            }
        }
        else
        {
            DisplayAlertAsync("Hang on", "Please enter a valid number", "Ok");
        }
    }
}