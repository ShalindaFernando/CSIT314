using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
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
        List<Users> UserArray = new List<Users>(50);

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

                   // System.Diagnostics.Debug.WriteLine("Reading text file.");

            using (var reader = new System.IO.StreamReader(stream))
            {
                //text = reader.ReadLine();
                text = reader.ReadToEnd();

                while (text != null)
                {
                    var parts = text.Split(',');
                    Users user = new Users();

                    user.userId = Convert.ToInt32(parts[0]);
                    user.fName = parts[1];
                    user.lName = parts[2];
                    user.email = parts[3];
                    user.userType = parts[4];
                    user.subscription = parts[5];
                    user.carMake = parts[6];
                    user.carModel = parts[7];
                    user.carColour = parts[8];
                    user.registration = parts[9];
                    user.transmission = Convert.ToBoolean(parts[10]);
                    user.cylinders = Convert.ToInt32(parts[11]);

                    UserArray.Add(user);
                    Console.WriteLine(user.print());
                }

            }

            //Permutate "text" variable to allow to be added to array.
        }

        private async void Navigate()
        {
            await Navigation.PushAsync(new LoginPage());
        }
    }
}
