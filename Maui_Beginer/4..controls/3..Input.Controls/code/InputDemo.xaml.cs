namespace Controls_App;

public partial class InputDemo : ContentPage
{
	public InputDemo()
	{
		InitializeComponent();
	}

    private void slider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        labelslider.Text = slider.Value.ToString();
    }
    
    private void stepper_ValueChanged(object sender, ValueChangedEventArgs e)
    {
       if(stepper != null)
        {
            labelstepper.Text = stepper.Value.ToString();
        }
    }
}