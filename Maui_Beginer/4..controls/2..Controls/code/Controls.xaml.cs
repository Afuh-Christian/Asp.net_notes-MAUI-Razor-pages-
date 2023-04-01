namespace Controls_App;

public partial class Controls : ContentPage
{
	public Controls()
	{
		InitializeComponent();
	}

    private void btnclick_Clicked(object sender, EventArgs e)
    {
		DisplayAlert("Title", "This is a demo", "ok");

    }



    private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        DisplayAlert("RadioButton", $"Changed: {e.Value}", "ok");
    }

    private void searhControl_SearchButtonPressed(object sender, EventArgs e)
    {
        DisplayAlert("Search", $"Searched: {searhControl.Text}","ok");
    }

    private void SwipeItem_Invoked(object sender, EventArgs e)
    {
        DisplayAlert("SwipeView", $"Intem tabbed","ok");
    }
}