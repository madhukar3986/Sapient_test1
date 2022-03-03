using System;
using System.Collections.Generic;
using System.Text;

namespace Sapient_Core.Models
{
    public class Medicines
    {
        public string medicineName { get; set; }
        public string Brand { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public DateTime Expirydate { get; set; }
        public string Notes { get; set; }
    }
}
