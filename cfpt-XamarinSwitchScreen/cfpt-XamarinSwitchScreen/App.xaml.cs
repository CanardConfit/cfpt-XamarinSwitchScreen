using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

namespace cfpt_XamarinSwitchScreen
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }
        
        /// <summary>
        /// Fonction qui permet de changer la page actuellement affichée.
        /// </summary>
        /// <param name="page">Page à affiché</param>
        public void ChangeScreen(Page page)
        {
            MainPage = page;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}