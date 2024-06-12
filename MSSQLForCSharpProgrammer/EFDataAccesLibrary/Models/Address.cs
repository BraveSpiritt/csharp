using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDataAccesLibrary.Models
{
    internal class Address
    {
        public int Id { get; set; }
        public string StreetAdress { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
    }
}
