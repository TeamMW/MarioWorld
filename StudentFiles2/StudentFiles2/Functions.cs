using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentFiles2
{
    public class Functions
    {
        public bool Freshman { get; private set; }
        public bool Graduate { get; private set; }
        public bool Junior { get; private set; }
        public bool Senior { get; private set; }
        public bool Sophmore { get; private set; }

        public void Age(int a, int b)
        {

            Console.WriteLine(a - b);
           
        }
        public void GPA(int a, int b)
        {
            Console.WriteLine(a + b % 2);  
        }
        public void GradeLevel(int credits)
        {
            if (credits <= 24)
            {
                Console.WriteLine(Freshman);
            }
            if (credits <= 49)
            {
                Console.WriteLine(Sophmore);
            }
            if (credits <= 74)
            {
                Console.WriteLine(Junior);
            }
            if (credits <= 99)
            {
                Console.WriteLine(Senior);
            }
            else
                Console.WriteLine(Graduate);
        }

    }
}


