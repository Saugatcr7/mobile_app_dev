namespace BreakTimer;

public partial class MainPage : ContentPage
{
    private int remainig_minutes;
    private bool isRunning = false;
    public MainPage()
    {
        InitializeComponent();
    }


    private void CountDown(int minutes)
    {
        if(isRunning)
            return;
        remainig_minutes = minutes;
        isRunning = true;
        Update();
        
        Dispatcher.StartTimer(TimeSpan.FromMinutes(1),(() =>
        {
            remainig_minutes--;
            
            if (remainig_minutes == 0)
            {
                lbldisplay.Text = "Time’s up!";
                isRunning=false;
                bool isRed = true;
                Dispatcher.StartTimer(TimeSpan.FromSeconds(0.5), (() =>
                {
                    if (isRed)
                    {
                        display.BackgroundColor=Colors.Red;

                    }
                    else
                    {
                        display.BackgroundColor=Colors.White;

                    }
                    isRed = !isRed;

                    return true;

                }));
               
                display.BackgroundColor=Colors.Red;
                return false;

            }
        
            Update();
            return true;
        }) );
        

    }

    private void Update()
    {
        lbldisplay.Text = $"{remainig_minutes} minutes left";
    }
    

   
    private void five_Button_OnClicked(object sender, EventArgs e)
    {
        CountDown(1);
        display.BackgroundColor=Colors.White;

    }

    private void ten_Button_OnClicked(object? sender, EventArgs e)
    {
        
        CountDown(10);
        display.BackgroundColor=Colors.White;

    }

    private void fifteen_Button_OnClicked(object? sender, EventArgs e)
    {
        
        CountDown(15);
        display.BackgroundColor=Colors.White;

    }
}