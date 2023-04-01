namespace Pages.contentpages;

public partial class MainPageNav : ContentPage
{


    public MainPageNav()
    {
        InitializeComponent();
    }

    private void goto_ContentPageDemo(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ContentPageDemo());
    }
}

