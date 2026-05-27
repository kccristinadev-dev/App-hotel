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
        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
}
