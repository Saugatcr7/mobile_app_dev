namespace Tip_Calculator;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
    }


    private void Button_OnClicked_15(object? sender, EventArgs e)
    {

        if (double.TryParse(amount.Text, out double Amount))

        {
            double change = Amount * 15/100;
            double sum = Amount + change;
            tip.Text=$"Tip: {change:C}";
            total.Text = $"Total:{sum:C}";
        }
    }

    private void Button_OnClicked_20(object? sender, EventArgs e)
    {
        
        if (double.TryParse(amount.Text, out double Amount))

        {
            double change = Amount * 20/100;
            double sum = Amount + change;
            tip.Text=$"Tip: {change:C}";
            total.Text = $"Total:{sum:C}";
        }
    }

    private void Button_OnClicked_25(object? sender, EventArgs e)
    {
        if (double.TryParse(amount.Text, out double Amount))

        {
            double change = Amount * 25/100;
            double sum = Amount + change;
            tip.Text=$"Tip: {change:C} |";
            total.Text = $"Total:{sum:C}";
        }
    }
}