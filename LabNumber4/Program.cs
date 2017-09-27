using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber4
{
    class Program
    {
        static void Main(string[] args)
        {
            //need to ask to use to enter a numer from 1 to 10 
            //need to display the factorial of the user entered number 
            //continue the application if the user agrees 

            //use a for loop to calculate the factorial 
            //use the long type to store the factorial 

            bool ProgramContinue = true;

            while (ProgramContinue == true)
            {

                int num1;
                long fact;


                Console.WriteLine("Please enter a number from 1 to 20");
                num1 = int.Parse(Console.ReadLine());
                fact = 1;


                //Console.WriteLine(num1);

                for (int i = 1; i <= num1; i++)
                {
                    fact = fact * i;
                }

                Console.WriteLine("The factorial of " + num1 + " " + "is" + " " + fact);



                string UserChoice;

                Console.WriteLine("Do you want to run the code again?");
                UserChoice = Console.ReadLine();

                if (UserChoice == "N" || UserChoice == "No" || UserChoice == "n" || UserChoice == "no")
                {
                    ProgramContinue = false;
                }

            }

        }
    }
}
