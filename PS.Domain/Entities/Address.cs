using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Domain.Entities
{
    [Owned]
    public class Address
    {
        public string City { get; set; }

        public string StreetAdress { get; set; }
    }
}
