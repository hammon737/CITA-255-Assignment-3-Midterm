namespace Midterm_Store;

public partial class NewPage4 : ContentPage
{
	public NewPage4()
	{
		InitializeComponent();
	}
    void Ordered(object sender, EventArgs e)
    {

        if (double.TryParse(orderEntry.Text, out double outNumber))
        {
            if (outNumber > 0 && outNumber < 99)
            {
                resultLabel.TextColor = Colors.MediumSeaGreen;
                resultLabel.Text = $"Added {outNumber}x Sensory Enhancement Potion to your cart.";
            }
            else
            {
                resultLabel.TextColor = Colors.DarkRed;
                resultLabel.Text = "That number can't be ordered. Try again with a number between 1 and 99.";
            }
        }
        else
        {
            resultLabel.TextColor = Colors.DarkRed;
            resultLabel.Text = "Please enter a valid number between 1 and 99";

        }
    }
}