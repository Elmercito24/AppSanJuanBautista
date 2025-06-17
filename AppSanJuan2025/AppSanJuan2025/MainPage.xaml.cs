namespace AppSanJuan2025
{
    public partial class MainPage : ContentPage
    {
       

        public MainPage()
        {
            InitializeComponent();
        }
        private async void OnMarinasClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MarineraPage());
        }

        private async void OnMotocrossClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MotocrosPage());
        }

        private async void OnNovenasClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NovenasPage());
        }

        private async void OnIngresarClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MarineraPage()); // Cambia el nombre si quieres otra página
        }

        private void OnMarineraClicked(object sender, EventArgs e)
        {
           Navigation.PushAsync(new MarineraPage());
        }
    }
}


