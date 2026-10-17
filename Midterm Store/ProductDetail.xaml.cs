using Microsoft.Maui.Graphics.Text;
using static System.Net.Mime.MediaTypeNames;

namespace Midterm_Store;

[QueryProperty(nameof(Index),"index")]

public partial class ProductDetail : ContentPage
{
    int index;

	public ProductDetail()
	{
		InitializeComponent();
        
	}

    public string Index
    {
        set
        {
            index = int.Parse(value);
            PotionImage.Source = Details.ProductImage[index];
            TitleLabel.Text = Details.ProductTitle[index];
            PriceLabel.Text = Details.Prices[index].ToString();
            Descrip1.Text = Details.Description1[index];
            Descrip2.Text = Details.Description2[index];
            IsStock.Text = Details.Stock[index];
            if (IsStock.Text == "Out of Stock") 
            {
                FirstBack.IsEnabled = false;
                
            }
        }
    }

    

    void Ordered(object sender, EventArgs e)
    {
        
        if (double.TryParse(orderEntry.Text, out double outNumber))
        {
            if (outNumber > 0 && outNumber < 99)
            {
                resultLabel.TextColor = Colors.MediumSeaGreen;
                resultLabel.Text = $"Added {outNumber}x {TitleLabel.Text} to your cart.";
                Cart.Names.Add(TitleLabel.Text);
                Cart.Quantity.Add(outNumber);
                Cart.Price.Add(13.99);
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