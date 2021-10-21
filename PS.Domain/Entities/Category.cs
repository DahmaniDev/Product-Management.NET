using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Domain.Entities
{
    public class Category : Concept
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }

        public IList<Product> Products { get; set; }

        public override string GetDetails()
        {
            return "[Category] CategoryId : " + CategoryId + ", Name : " + Name;
        }
    }
}
