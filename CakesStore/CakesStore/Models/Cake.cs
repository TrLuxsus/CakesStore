using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CakesStore.Models
{
    public class Cake
    {
        public int CakeID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}
