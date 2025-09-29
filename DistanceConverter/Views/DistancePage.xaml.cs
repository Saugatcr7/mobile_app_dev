using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter.Views;

public partial class DistancePage : ContentPage
{
    private double Keyvalue = 0;     

    private double dbl_m2f  = 3.28084;     
    private double dbl_m2i  = 39.3701;     
    private double dbl_m2mi = 0.000621371;  
    private double dbl_m2m  = 1.0;          
    private double dbl_m2nm = 0.000539957;  
    private double dbl_m2y  = 1.09361;     
    private double dbl_m2k  = 0.001;        


    public DistancePage()
    {
        InitializeComponent();
        Title = "DISTANCE CONVERTER";
        ToolbarItem tbi = new ToolbarItem();
        tbi.Text="About";
        this.ToolbarItems.Add(tbi);
        tbi.Clicked += delegate
        {
         Navigation.PushAsync(new AboutPage());
        };
    }

    private void Clear_OnClicked(object? sender, EventArgs e)
    {
        txtMeters.Text = "";
        txtInches.Text = "";
        txtFeet.Text = "";
        txtYards.Text = "";
        txtNautical.Text = "";
        txtMiles.Text = "";
        txtKiloMeters.Text = "";
    }

    private void TxtMeters_OnTextChanged(object? sender, TextChangedEventArgs e)
    {
        double dblNUm;
        var isinvalid=Double.TryParse(txtMeters.Text, out dblNUm);
        if (isinvalid && dblNUm >= 0)
        {
            Keyvalue=dblNUm/dbl_m2m;
        }
        else
        {
            Keyvalue = 0;
        }

    }

    private void TxtInches_OnTextChanged(object? sender, TextChangedEventArgs e)
    {
        double dblNUm;
        var isinvalid=Double.TryParse(txtInches.Text, out dblNUm);
        if (isinvalid && dblNUm >= 0)
        {
            Keyvalue=dblNUm/dbl_m2i;
        }
        else
        {
            Keyvalue = 0;
        }
        
    }

    private void TxtFeet_OnTextChanged(object? sender, TextChangedEventArgs e)
    {
        double dblNUm;
        var isinvalid=Double.TryParse(txtFeet.Text, out dblNUm);
        if (isinvalid && dblNUm >= 0)
        {
            Keyvalue=dblNUm/dbl_m2f;
        }
        else
        {
            Keyvalue = 0;
        }
        
    }

    private void TxtYards_OnTextChanged(object? sender, TextChangedEventArgs e)
    {
        
        double dblNUm;
        var isinvalid=Double.TryParse(txtYards.Text, out dblNUm);
        if (isinvalid && dblNUm >= 0)
        {
            Keyvalue=dblNUm/dbl_m2y;
        }
        else
        {
            Keyvalue = 0;
        }
    }

    private void TxtNautical_OnTextChanged(object? sender, TextChangedEventArgs e)
    {
        double dblNUm;
        var isinvalid=Double.TryParse(txtNautical.Text, out dblNUm);
        if (isinvalid && dblNUm >= 0)
        {
            Keyvalue=dblNUm/dbl_m2nm;
        }
        else
        {
            Keyvalue = 0;
        }
        
    }

    private void TxtMiles_OnTextChanged(object? sender, TextChangedEventArgs e)
    {
        double dblNUm;
        var isinvalid=Double.TryParse(txtMiles.Text, out dblNUm);
        if (isinvalid && dblNUm >= 0)
        {
            Keyvalue=dblNUm/dbl_m2mi;
        }
        else
        {
            Keyvalue = 0;
        }
        
    }

    private void TxtKiloMeters_OnTextChanged(object? sender, TextChangedEventArgs e)
    {
        double dblNUm;
        var isinvalid=Double.TryParse(txtKiloMeters.Text, out dblNUm);
        if (isinvalid && dblNUm >= 0)
        {
            Keyvalue=dblNUm/dbl_m2k;
        }
        else
        {
            Keyvalue = 0;
        }
        
    }

    private void Convert_OnClicked(object? sender, EventArgs e)
    {
        txtMeters.Text = (Keyvalue*dbl_m2m).ToString("g9");
        txtInches.Text = (Keyvalue*dbl_m2i).ToString("g9");
        txtFeet.Text = (Keyvalue*dbl_m2f).ToString("g9");
        txtYards.Text = (Keyvalue*dbl_m2y).ToString("g9");
        txtNautical.Text = (Keyvalue*dbl_m2nm).ToString("g9");
        txtMiles.Text = (Keyvalue*dbl_m2mi).ToString("g9");
        txtKiloMeters.Text = (Keyvalue*dbl_m2k).ToString("g9"); 
        
        
    }
}