using System;
using Xamarin.Forms;

namespace cfpt_XamarinSwitchScreen
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evenement du bouton.
        /// </summary>
        private void Button_OnClicked(object sender, EventArgs e)
        {
            // Permet de changer de page
            ((App)App.Current).ChangeScreen(new AnotherPage());
        }
    }
}