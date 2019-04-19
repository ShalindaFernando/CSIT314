using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;
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

        private void LoadData()
        {
            //Load Users Information into Array
            var assembly = typeof(MainPage).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream("Group13.UsersData.txt");
            string text = "";

            using (var reader = new System.IO.StreamReader(stream))
            {
                text = reader.ReadToEnd();
            }
            System.Diagnostics.Debug.WriteLine("Reading text file.");
            System.Diagnostics.Debug.WriteLine(text);

            //Permutate "text" variable to allow to be added to array.
        }

        private async void Navigate()
        {
            await Navigation.PushAsync(new LoginPage());
        }
    }
}
