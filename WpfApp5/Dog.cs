using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp5
{
    public class Dog : Animal
    {
        //metod för att beräkna hundår
        public int CalculateDogYears()
        {
            int dogYears = Age * 5;

            if (Age >= 1) 
            {
                dogYears += 10;
            }
            if (Age >= 2)
            {
                dogYears += 4;
            }
            return dogYears;
        }

        public override string ToString()
        {
            return Race + " " + CalculateDogYears();
        }
    }
}
