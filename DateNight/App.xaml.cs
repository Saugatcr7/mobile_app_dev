using DateNight.Models;
namespace DateNight;

public partial class App : Application
{
    public static DateCalculator dateCalculator;
    public App()
    {
        InitializeComponent();
        dateCalculator = new DateCalculator();
        MainPage=new AppShell();
    }
}