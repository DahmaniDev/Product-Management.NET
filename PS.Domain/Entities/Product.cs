using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Domain.Entities
{
    public class Product : Concept
    {
        //ctor+2tab
        public Product() { }

        public Product(int productId, DateTime dateProd, string description, string name, double price, int quantity)
        {
            ProductId = productId;
            DateProd = dateProd;
            Description = description;
            Name = name;
            Price = price;
            Quantity = quantity;
        }
        #region Example
        // Region pour pouvoir grouper un bloc de code
        //prop + 2 tab :light version
        //Propriétés de Base
        public int ProductId { get; set; }
        public DateTime DateProd { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public string imageUrl3 { get; set; }

        /*
        //propg + 2 tab : secure version
        public double Price { get; private set; }


        //propfull + 2 tab : full version (Pour pouvoir changer la méthode set et get
        private int myVar;

        public int Quantity
        {
            get { return myVar; }
            set { myVar = value; }
        }
        */
        //Propriétés de Navigation (Relations)
        public Category Category { get; set; }
        public IList<Provider> Providers { get; set; }

        public override string GetDetails()
        {
            return "[Product] Name : " + Name + ", Price : " + Price + ", Description : " + Description;
        }

        public virtual string GetMyType()
        {
            return "UNKNOWN";
        }
        #endregion
    }
}
