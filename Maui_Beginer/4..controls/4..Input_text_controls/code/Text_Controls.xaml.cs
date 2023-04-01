using System.Diagnostics;

namespace Controls_App;

public partial class Text_Controls : ContentPage
{
    public Text_Controls()
    {
        InitializeComponent();
    }

    private void Entry_TextChanged(object sender, TextChangedEventArgs e)
    {
        Debug.WriteLine(txtName.Text);
    }

    private void Entry_Completed(object sender, EventArgs e)
    {
        Debug.WriteLine("You finished typing");
    }
}