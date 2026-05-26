using Microsoft.Maui.Controls;

namespace AppHotel
{
    public partial class MainPage : ContentPage
    {
    
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCounterClicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new Views.HomePage());
        }
    }
}
