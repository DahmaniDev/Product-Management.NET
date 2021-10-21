using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Domain.Entities
{
    public class Chemical : Product
    {
        public Address LabAddress { get; set; }
        public string LabName { get; set; }
        public override string GetDetails()
        {
            //base est le "super" de java
            return base.GetDetails() + "[Chemical] City : " + LabAddress.City + ", LabName : " + LabName + ", St Address : " + LabAddress.StreetAdress;
        }

        public override string GetMyType()
        {
            return "CHEMICAL";
        }
    }
}
