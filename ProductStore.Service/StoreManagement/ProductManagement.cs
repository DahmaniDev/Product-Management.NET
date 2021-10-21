using PS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductStore.Service.StoreManagement
{
    public class ProductManagement
    {
        List<Product> myProducts;

        public ProductManagement(List<Product> products)
        {
            myProducts = products;
        }

        public IEnumerable<Chemical> Get5Chemical(double price)
        {
            //Linq
            //var query = from p in myProducts.OfType<Chemical>()
            //            where p.Price > price
            //            select p;
            //return query.Take(5).AsEnumerable();

            //Lambda
            return myProducts.OfType<Chemical>().Where(p => p.Price > price).Take(5);
        }

        public IEnumerable<Product> GetProductsByPrice(double price)
        {
            //Linq
            //return (from p in myProducts
            //        where p.Price > price
            //        select p).Skip(2);

            //Lambda
            return myProducts.Where(p => p.Price > price).Skip(2);
        }

        public double GetAveragePrice()
        {
            //Lambda
            return myProducts.Average(p => p.Price);
            //Linq
            //return (from p in myProducts select p.Price).Average();
        }

        public Product GetProductByMaxPrice()
        {
            return myProducts.OrderBy(p => p.Price).LastOrDefault();
            //return myProducts.OrderByDescending(p => p.Price).FirstOrDefault();
            //return myProducts.OrderBy(p => p.Price).Reverse().FirstOrDefault();
        }

        public int GetCountProduct(string city)
        {
            //Lambda
            return myProducts.OfType<Chemical>().Count(c => c.LabAddress.City.Equals(city));
        }

        public IEnumerable<Chemical> GetChemicalCity()
        {
            return myProducts.OfType<Chemical>().OrderBy(p => p.LabAddress.City);
        }

        public IGrouping<string,IEnumerable<Chemical>> GetChemicalGroupByCity()
        {
            return (IGrouping<string, IEnumerable<Chemical>>)myProducts.OfType<Chemical>().OrderBy(c=> c.LabAddress.City).GroupBy(c => c.LabAddress.City);
        }

        public void GetChemicalGroupByCityRes()
        {
            var result = myProducts.OfType<Chemical>().OrderBy(c => c.LabAddress.City).GroupBy(c => c.LabAddress.City);
            foreach(var ProductByCity in result)
            {
                Console.WriteLine("City : "+ProductByCity.Key);
                foreach(var prod in ProductByCity)
                {
                    Console.WriteLine("Product : "+prod.Name);
                }
            }
        }
    }
}
