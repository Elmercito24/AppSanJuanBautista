namespace AppSanJuan2025;

public partial class MenuPage : ContentPage
{
	public MenuPage()
	{
		InitializeComponent();
	}
    private async void OnNavigate(object sender, EventArgs e)
    {
        var button = (Button)sender;
        string dia = button.CommandParameter.ToString();
        await Navigation.PushAsync(new DetalleEventoPage(dia));
    }
}