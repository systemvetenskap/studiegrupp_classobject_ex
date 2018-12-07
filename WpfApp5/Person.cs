using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp5
{
    public class Person
    {
        public string Name { get; set; }

        public List<Animal> animals { get; set; }

        public Person()
        {
            animals = new List<Animal>();
        }

        public void AddAnimal(Animal a)
        {
            animals.Add(a);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
