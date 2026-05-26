using Microsoft.Maui.Controls;

namespace AppHotel
{
    public partial class App : Application
    {

    List<Quartos> lista_quartos = new List<Quartos>{

            new Quarto()
            {
                Descricao = "Suíte Super Luxo",
                ValorDiariaAdulto = 110.0,
                ValorDiariaCrianca = 55.0
            },
            new Quarto()
            {
                Descricao = "Suíte Luxo",
                ValorDiariaAdulto = 80.0,
                ValorDiariaCrianca = 40.0
            },
            new Quarto()
            {
                Descricao = "Suíte Single",
                ValorDiariaAdulto = 50,
                ValorDiariaCrianca = 25
            },
            new Quarto()
            {
                Descricao = "Suíte Crise",
                ValorDiariaAdulto = 25,
                ValorDiariaCrianca = 12.5
            }
            

    };
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
