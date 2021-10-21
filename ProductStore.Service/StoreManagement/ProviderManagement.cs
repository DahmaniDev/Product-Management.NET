using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PS.Domain.Entities;

namespace ProductStore.Service.StoreManagement
{
    public class ProviderManagement
    {
        public bool SetIsApproved(Provider p)
        {
            if (p.Password == null || p.ConfirmPassword == null)
                return false;
            return p.Password.Equals(p.ConfirmPassword);
        }

        
        public IEnumerable<Provider> GetProviderByName(string name, List<Provider> myProviders)
        {
            //Méthode Classique
            //List<Provider> result = new List<Provider>();
            //foreach (Provider p in myProviders)
            //{
            //    if (p.Username.Contains(name))
            //        result.Add(p);
            //}
            //return result.AsEnumerable();
            //Méthode LinQ
            var query = from p in myProviders
                        where p.Username.StartsWith(name)
                        select p;
            return query.AsEnumerable();
        }

        public Provider GetFirstProviderByName(string name, List<Provider> myProviders)
        {
            var query = from p in myProviders
                        where p.Username.StartsWith(name)
                        select p;
            return query.FirstOrDefault(); //First() génére une exception si query est vide 
        }

        public Provider GetProviderById(int id, List<Provider> myProviders)
        {
            return (from p in myProviders
                        where p.Id == id
                        select p).SingleOrDefault();
        }




    }
}
