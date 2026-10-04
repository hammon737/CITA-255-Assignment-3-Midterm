namespace Midterm_Store;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
	}
    void Ordered(object sender, EventArgs e)
    {
        try
        {
            int orderNum = int.Parse(orderEntry.Text);
            resultLabel.Text = $"Added +{orderNum} Item 1 to your cart.";
        }
        catch (ArgumentOutOfRangeException)
        {
            DisplayAlertAsync("This is way too many!", "Please enter a number between 1 and 99.", "Ok");
        }
        catch (System.FormatException)
        {
            DisplayAlertAsync("This is not a number", "Please enter a number between 1 and 99.", "Ok");
        }
        catch (OverflowException)
        {
            DisplayAlertAsync("This is way too long!", "Please enter a number between 1 and 99.", "Ok");
        }
        catch (ArgumentNullException)
        {
            DisplayAlertAsync("Where'd you go?", "There's nothing here.", "Ok");
        }
    }
}