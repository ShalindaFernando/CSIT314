using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Group13
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Task.Run(() => { LoadData(); });

            Navigate();
        }

        private async void LoadData()
        {
            //Load Users Information into Array
            await Task.Run(() => { UserData.GetUserDetails();});
        }

        private async void Navigate()
        {
            await Navigation.PushAsync(new LoginPage());
        }
    }
}
