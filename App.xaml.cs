using Microsoft.Maui.Controls;

namespace AppHotel
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new MainPage();
        }

        protected override Window CreateWindow(IactivationState? activationState){
            var Window = base.CreateWindow(activationState);
         Window.Width = 400;
        hWindow.Height = 600;
            return Window;
        }
    }
}
