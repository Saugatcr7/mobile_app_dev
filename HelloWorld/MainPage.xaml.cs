namespace HelloWorld;

public partial class MainPage : ContentPage
{
    

    public MainPage()
    {
        InitializeComponent();
    }


    private void Button_OnClicked(object? sender, EventArgs e)
    {
        if (lblDisplay.Text == "Hello World")
        {
            lblDisplay.Text = "That's what I am talking about!";
        }
        else
        {
            lblDisplay.Text = "Hello World";
        }
        
       
    }
}