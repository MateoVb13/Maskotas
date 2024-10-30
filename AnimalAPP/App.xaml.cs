namespace AnimalAPP
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new Pages.LoginPage()); // Configura LoginPage como página de inicio
        }
    }
}
