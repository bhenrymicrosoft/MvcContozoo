using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcContozoo.Models
{
    public class Animals
    {
        public int AnimalId { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public string Location { get; set; }
        public string ActiveHours { get; set; }
        public string Notes { get; set; }
    }
}
