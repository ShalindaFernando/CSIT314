using System;
namespace Group13
{
    public class Users
    {
        public int userId { get; set; }
        public String fName { get; set; }
        public String lName { get; set; }
        public String email { get; set; }
        public String userType { get; set; }
        public String subscription { get; set; }
        public String carMake { get; set; }
        public String carModel { get; set; }
        public String carColour { get; set; }
        public String registration { get; set; }
        public bool transmission { get; set; }
        public int cylinders { get; set; }

        public Users()
        {

        }

        public Users(int userId, string fName, string lName, string email, string userType, string subscription, string carMake, string carModel, string carColour, string registration, bool transmission, int cylinders)
        {
            this.userId = userId;
            this.fName = fName;
            this.lName = lName;
            this.email = email;
            this.userType = userType;
            this.subscription = subscription;
            this.carMake = carMake;
            this.carModel = carModel;
            this.carColour = carColour;
            this.registration = registration;
            this.transmission = transmission;
            this.cylinders = cylinders;
        }

        public string print ()
        {
            return (fName + " " + lName);
        }
    }
}
