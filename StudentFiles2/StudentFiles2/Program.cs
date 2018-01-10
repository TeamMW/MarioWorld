using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentListing2
{
    class Program
    {
        private static string option;

        static void Main(string[] args)
        {
            //string option = "";

            do
            {
                Console.Clear();

                Console.WriteLine("Student Listing: ");
                Console.WriteLine("------------------");
                Console.WriteLine("To Learn About A Student Select The Letter Next To The Name:");
                Console.WriteLine("A: Marcus Jones");
                Console.WriteLine("B: Patty Mayonnaise");
                Console.WriteLine("C: TJ Deitwieller");
                Console.WriteLine("D: Tom Jerry");
                Console.WriteLine("E: PepperAnn Finster");

                Console.WriteLine(" ");
                Console.Write("Selection):  ");
                string userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "A":
                        StudentA();
                        break;
                    case "B":
                        StudentB();
                        break;
                    case "C":
                        StudentC();
                        break;
                    case "D":
                        StudentD();
                        break;
                    case "E":
                        StudentE();
                        break;


                }
            }

            while (true);
            {

            }

            Console.ReadLine();
        }





        private static void StudentA()
        {
            Console.Clear();
            Console.WriteLine("Name: Marcus Jones");

            Console.WriteLine("Birthday: ");
            Console.WriteLine("Gender: ");
            Console.WriteLine("Grades: ");
            Console.WriteLine("Credits: ");
            Console.WriteLine("ID: ");


            Console.WriteLine("Select Q to Return to the previous menu");

            Console.WriteLine(" ");
            Console.Write("Selection):  ");


            while (true)
            {
                var option = Console.ReadLine();
                switch (option)
                {
                    case "Q":
                    case "q":
                        return;

                }
            }

        }

        private static void StudentB()
        {
            Console.Clear();
            Console.WriteLine("Name: Patty Mayonnaise");

            Console.WriteLine("Birthday: ");
            Console.WriteLine("Gender: ");
            Console.WriteLine("Grades: ");
            Console.WriteLine("Credits: ");
            Console.WriteLine("ID: ");


            Console.WriteLine("Select Q to Return to the previous menu");

            Console.WriteLine(" ");
            Console.Write("Selection):  ");


            while (true)
            {
                var option = Console.ReadLine();
                switch (option)
                {
                    case "Q":
                    case "q":
                        return;

                }
            }


        }

        private static void StudentC()
        {
            Console.Clear();
            Console.WriteLine("Name: TJ Deitwieller");

            Console.WriteLine("Birthday: ");
            Console.WriteLine("Gender: ");
            Console.WriteLine("Grades: ");
            Console.WriteLine("Credits: ");
            Console.WriteLine("ID: ");


            Console.WriteLine("Select Q to Return to the previous menu");

            Console.WriteLine(" ");
            Console.Write("Selection):  ");


            while (true)
            {
                var option = Console.ReadLine();
                switch (option)
                {
                    case "Q":
                    case "q":
                        return;

                }
            }


        }

        private static void StudentD()
        {
            Console.Clear();
            Console.WriteLine("Name: Tom Jerry");

            Console.WriteLine("Birthday: ");
            Console.WriteLine("Gender: ");
            Console.WriteLine("Grades: ");
            Console.WriteLine("Credits: ");
            Console.WriteLine("ID: ");


            Console.WriteLine("Select Q to Return to the previous menu");

            Console.WriteLine(" ");
            Console.Write("Selection):  ");


            while (true)
            {
                var option = Console.ReadLine();
                switch (option)
                {
                    case "Q":
                    case "q":
                        return;

                }
            }


        }

        private static void StudentE()
        {
            Console.Clear();
            Console.WriteLine("Name: PepperAnn Finster");

            Console.WriteLine("Birthday: ");
            Console.WriteLine("Gender: ");
            Console.WriteLine("Grades: ");
            Console.WriteLine("Credits: ");
            Console.WriteLine("ID: ");


            Console.WriteLine("Select Q to Return to the previous menu");

            Console.WriteLine(" ");
            Console.Write("Selection):  ");


            while (true)
            {
                var option = Console.ReadLine();
                switch (option)
                {
                    case "Q":
                    case "q":
                        return;

                }
            }


        }




    }

}
