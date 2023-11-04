using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMInitialExample
{
    public class Model
    {
        public Model(string _title, string _description, double _quantity) 
        {
            Title = _title;
            Description = _description;
            Quantity = _quantity;
        }

        public string Title { get; set; } = "";
        public string Description { get; set; } = "";
        public double Quantity { get; set; } = 0;
    }
}
