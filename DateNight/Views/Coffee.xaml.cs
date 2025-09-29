using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateNight.Views;

public partial class Coffee : ContentPage
{
    public Coffee()
    {
        InitializeComponent();
    }

    protected override void OnDisappearing()
    {
        base.OnDisappearing();
        App.dateCalculator.CoffeeCost = txtCoffee.Text;
    }
}