using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Group13
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            NavigationPage.SetHasBackButton(this, false);
            NavigationPage.SetHasNavigationBar(this, false);


        }

        private async void Login_Check(object sender, EventArgs e)
        {
            if (Username.Text == ""/* Change to check array for username */ && Password.Text == "" /*Change to check array for password*/)
            {
                await Navigation.PushAsync(new HomePage());
            }
            else
            {
                await DisplayAlert("Error", "User not found. Please register for a new account", "Ok");
            }

        }
    }
}
