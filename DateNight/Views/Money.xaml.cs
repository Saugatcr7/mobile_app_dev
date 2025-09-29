using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateNight.Views;

public partial class Money : ContentPage
{
    public Money()
    {
        InitializeComponent();
        
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        try
        {
            lblMoney.Text = App.dateCalculator.GetTotalCost();

        }
        catch (Exception ex)
        {
            DisplayAlert("Error", ex.Message, "OK");
            lblMoney.Text="Error";
        }
    }
}