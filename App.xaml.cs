using Microsoft.Maui.Controls;

namespace AppHotel
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new MainPage());
        }

        protected override Window CreateWindow(IactivationState? activationState){
            var window = base.CreateWindow(activationState);
         window.Width = 400;
        window.Height = 600;
            return Window;
        }
    }
}
