using SignInAppGIT.Modles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SignInAppGIT
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void SignInUser_Clicked(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(emailEntry.Text) || string.IsNullOrEmpty(passwordEntry.Text))
            {
                DisplayAlert("Błąd", "Uzupełnij pola", "OK");
            }
            else
            {
                User user = new User();

                user.Email = emailEntry.Text;
                user.Password = passwordEntry.Text;

                App.loggedUser = user;
            }
        }
    }
}
