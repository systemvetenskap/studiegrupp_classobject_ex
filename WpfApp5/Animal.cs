using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp5
{
    public abstract class Animal
    {
        public string Race { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return Race + " " + Age;
        }
    }
}
