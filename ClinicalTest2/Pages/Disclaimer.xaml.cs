namespace ClinicalTest2.Pages;

public partial class Disclaimer : ContentPage
{
    public Disclaimer()

    {
        InitializeComponent();
        Routing.RegisterRoute("Home", typeof(Home));
    }

    private async void ImageButton_OnClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//Home");

    }
   
}

