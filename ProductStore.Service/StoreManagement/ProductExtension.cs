using PS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductStore.Service.StoreManagement
{
    public static class ProductExtension
    {
        public static string UpperName(this ProductManagement prodManagement, string ch)
        {
            return ch.ToUpper();
        }

        public static string LowerName(this ProviderManagement prodManagement, string ch)
        {
            return ch.ToLower();
        }

        public static bool InCategory(this ProductManagement prodManagement, Product prod, string cat)
        {
            return prod.Category.Name.Equals(cat);
        }
    }
}
