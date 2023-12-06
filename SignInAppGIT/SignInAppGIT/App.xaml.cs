using SignInAppGIT.Modles;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SignInAppGIT
{
    public partial class App : Application
    {
        public static User loggedUser = null;
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
