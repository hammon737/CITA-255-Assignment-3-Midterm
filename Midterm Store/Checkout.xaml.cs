using Microsoft.Maui.Controls.Shapes;
using System.Diagnostics;

namespace Midterm_Store;

public partial class NewPage5 : ContentPage
{
	public NewPage5()
	{
		InitializeComponent();
	}
    protected override void OnAppearing()
    {
        base.OnAppearing();
        Refresh();
    }

    private void checkingOut(object sender, EventArgs e)
    {
        Cart.Names.Clear();
        Cart.Quantity.Clear();
        Cart.Price.Clear();
        Refresh();
        purchaseLabel.Text = "Thank you for your purchase!";
    }

    void Refresh()
    {
        List<string> lines = new List<string>();

        double total = 0.00;

        for (int i = 0; i < Cart.Names.Count; i++)
        {
            double totalPrice = Cart.Price[i] * Cart.Quantity[i];
            lines.Add($"{Cart.Names[i]} x{Cart.Quantity[i]}");
            total += totalPrice;
        }

        CartView.ItemsSource = null;
        CartView.ItemsSource = lines;
        totalLabel.Text = $"${total:F2}";
        purchaseLabel.Text = " ";

    }
}