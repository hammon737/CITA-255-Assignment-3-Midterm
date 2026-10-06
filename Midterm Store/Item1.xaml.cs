using Microsoft.Maui.Graphics.Text;

namespace Midterm_Store;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
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
                resultLabel.Text = $"Added {outNumber}x Item 1 to your cart.";
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