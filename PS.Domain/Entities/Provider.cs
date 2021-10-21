using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Domain.Entities
{
    //public class sealed Provider : Concept est une classe qui ne peut pas être héritée
    public class Provider : Concept
    {
        //public string ConfirmPassword { get; set; }
        private string myConfirmPass;

        public string ConfirmPassword
        {
            get { return myConfirmPass; }
            set {
                if (value.Equals(Password))
                    myConfirmPass = value;
                else
                    throw new System.Exception("Passwords must be the same!");
            }
        }

        //public string Password { get; set; }
        private string myPass;

        public string Password
        {
            get { return myPass; }
            set {
                if (value.Length >= 5 && value.Length <= 20)
                    myPass = value;
                else
                    throw new System.Exception("Password length must be in [5..20 ]");
            }
        }

        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public string Email { get; set; }
        public bool IsApproved { get; set; }
        public string Username { get; set; }

        public IList<Product> Products { get; set; }

        public override string GetDetails()
        {
            string str = "[Provider] Username : " + Username + ", Email : " + Email;
            if(Products!=null)
            {
                foreach (Product p in Products)
                {
                    str += "\n " + p.GetDetails();
                }
            }
            
            return str;
        }

        public bool Login(string username, string password)
        {
            return Username.Equals(username) && Password.Equals(password);
        }

        public bool Login(string username, string password, string email)
        {
            return Login(username, password) && Email.Equals(email);
        }

        public void GetProducts ( string filterName, string filterValue)
        {
            switch (filterName.ToLower())
            {
                case "dateprod":
                    foreach(Product p in Products)
                    {
                        if (p.DateProd.Equals(filterValue))
                            Console.WriteLine(p.GetDetails());
                    }
                    break;
                case "name":
                    foreach (Product p in Products)
                    {
                        if (p.Name.Equals(filterValue))
                            Console.WriteLine(p.GetDetails());
                    }
                    break;
            }
        }

        //3eme méthode contient le corps des deux méthodes ci-dessus avec test sur le email si il est null ou pas

    }
}
