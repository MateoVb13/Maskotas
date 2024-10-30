namespace AnimalAPP
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new Detalle()); // Configura Detalle como página de inicio
        }
    }
}
