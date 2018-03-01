using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheeseMVC.Models
{
    public class CheeseCategory
    {
        //Add ID and Name Property
        public string Name { get; set; }
        public int ID { get; set; }
        public IList<Cheese> Cheeses { get; set; }  // represents the list of all items in a given category

    }
}
