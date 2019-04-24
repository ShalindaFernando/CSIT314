using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Group13.Registration
{
    public partial class UserDetails : ContentPage
    {
        public UserDetails()
        {
            InitializeComponent();
            NavigationPage.SetHasBackButton(this, false);
            NavigationPage.SetHasNavigationBar(this, false);

        }

        public async void NextPage(object sender, EventArgs e)
        {
            //Check Users input here before allowing next page to be presented

            await Navigation.PushAsync(new CarDetails());
        }

        public async void PrevPage(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

    }
}
