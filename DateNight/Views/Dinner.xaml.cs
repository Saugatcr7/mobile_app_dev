using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateNight.Views;

public partial class Dinner : ContentPage
{
    public Dinner()
    {
        InitializeComponent();
    }
    protected override void OnDisappearing()
    {
        base.OnDisappearing();
        App.dateCalculator.DinnerCost = txtDinner.Text;
    }
}