using System;
using PS.Domain.Entities;
using ProductStore.Service.StoreManagement;
using System.Collections.Generic;
using PS.Data;

namespace PS.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World!");

            Provider p = new Provider
            {
                Email = "Dahmani@esprit.tn",
                Username = "Dahmani"
            };
            try {
                p.Password = "1234545";
                p.ConfirmPassword = "1234545";
            }
            catch (Exception e) { System.Console.WriteLine(e.Message); }
            
            p.IsApproved = false;
            //Constructeur classique
            Product prod = new Product(1,new DateTime(2021,09,07),"Produit1 description","KITKAT",15.0,50);
            Product prod3 = new Product(3, new DateTime(2021, 1, 10), "Prod3 description", "NUTELLA", 55.0, 150);
            //Initialiseur d'objet !:on doit créer un constructeur vide
            Product prod2 = new Product {Description="Description n°2", ProductId=2, Name="TWIX", Price=20.0, DateProd= new DateTime(2021, 10, 09), Quantity=20 };
            Chemical chem1 = new Chemical { Description = "Description n°3 Chemical", ProductId = 3, Name = "SUNSILK", Price = 80.0, DateProd = new DateTime(2021, 02, 19), Quantity = 120 };
            //cwl + 2 Tab
            System.Console.WriteLine("@ Provider : " + p.GetDetails());
            Chemical chem = new Chemical
            {
                LabAddress = new Address
                {
                    City = "Ariana",
                    StreetAdress = "Chotrana",
                },
                Name = "Chemical product",
                DateProd = new DateTime(2020, 10, 02),
                Category = new Category { Name = "mycategory" }
            };
            Chemical chem2 = new Chemical
            {
                LabAddress = new Address
                {
                    City = "Ben Arous",
                    StreetAdress = "Rades",
                },
                Name = "Chemical product2",
                Price = 100,
                Quantity = 20,
                Description = "nice",
                DateProd = DateTime.Now
            };
            ProviderManagement pm = new ProviderManagement();

            System.Console.WriteLine("[Before] isApproved ? " + p.IsApproved);
            p.IsApproved = pm.SetIsApproved(p);
            System.Console.WriteLine("[After] isApproved ? " + p.IsApproved);

            System.Console.WriteLine("LOGIN !!");
            System.Console.WriteLine(p.Login("Dahmani", "1234545", "Dahmani@" +
                "esprit.tn"));
            System.Console.WriteLine("Type : "+chem.GetMyType());
            System.Console.WriteLine("Type : " + prod.GetMyType());
            System.Console.WriteLine("Type : " + prod2.GetMyType());


            ProductManagement prodManagement = new ProductManagement(new List<Product> {chem,chem2});
            System.Console.WriteLine(""+prodManagement.UpperName(prod2.Name));
            System.Console.WriteLine("Nb Prod in Ariana : "+prodManagement.GetCountProduct("Ariana"));
            System.Console.WriteLine("******************************");
            prodManagement.GetChemicalGroupByCityRes();
            System.Console.WriteLine("******************************");
            System.Console.WriteLine(prodManagement.InCategory(chem,"mycategory"));

            //***************************************************************

            PSContext context = new PSContext();
            context.Products.Add(chem); //Products est une liste (DbSet)
            context.SaveChanges(); //Persister les données à la BD (Synchronisation)

        }
    }
}
