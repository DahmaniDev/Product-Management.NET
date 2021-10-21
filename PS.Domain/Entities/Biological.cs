using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Domain.Entities
{
    public class Biological : Product
    {
        public string Herbs { get; set; }

        public override string GetDetails()
        {
            return base.GetDetails() + "[Biological] Herbs : " + Herbs;
        }

        public override string GetMyType()
        {
            return "BIOLOGICAL";
        }
    }
}
