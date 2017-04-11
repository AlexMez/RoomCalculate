using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCommunityProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //start a loop, to break out the user has to choose to stop picking rooms
            bool again = true;
            while (again == true)
            //Console.WriteLine("Welcome to classroom area and perimeter App");
            {


                //get Length, Width and Height from user
                Console.Write("Enter the Lenghth of the classroom in inches: ");
                string inputLength = Console.ReadLine();

                Console.Write("Enter the Width in inches: ");
                string inputWidth = Console.ReadLine();

                Console.Write("Enter the Height of the Room in inches: ");
                string inputHeight = Console.ReadLine();

                

                //Validate to  see if they inputted numbers
                if ((Validate(inputLength)) == 1)
                    break;   

                if ((Validate(inputWidth)) == 1)
                    break;

                if ((Validate(inputHeight)) == 1)
                    break;

                //seperate input from results
                Console.WriteLine("--------------------------------------");
                
                //convert inputted strings to double
                double workHeight = Convert.ToDouble(inputHeight);
                double workLength = Convert.ToDouble(inputLength);
                double workWidth = Convert.ToDouble(inputWidth);

                //print results
                Console.WriteLine("The area of the classroom in inches is: "
                    + CalcualteArea(workLength, workWidth));
                Console.WriteLine("The Perimeter of the classroom in inches is: "
                    + CalculatePerim(workLength, workWidth));
                Console.WriteLine("the Volume of the classroom in inches is: "
                    + CalculateVol(workHeight, workLength, workWidth));

                Console.WriteLine("-------------------------------");

                //ask to stop or keep checking rooms
                Console.WriteLine("enter 1 to continue checking rooms or 2 to exit");
                string userInput = Console.ReadLine();
                int userOneorTwo = Convert.ToInt16(userInput);

                if (userOneorTwo == 2)
                {
                    again = false;
                }
                else
                {
                    again = true;
                }
                Console.Clear();
            }

            

        }

        private static double CalcualteArea(double length, double width)
        {
            double length1 = length;
            double width2 = width;
            double area = length1 * width2;
            return area;
        }

        private static double CalculatePerim(double length, double width)
        {
            double lengh1 = length;
            double width2 = width;
            double perim = (width2 * 2) + (lengh1 * 2);
            return perim;
        }

        private static double CalculateVol(double x, double y, double z)
        {
            double Vol = x * y * z;
            return Vol;
        }

        private static int Validate(string inputted)
        { 
            int num1;
            bool res = int.TryParse(inputted, out num1);
            if (res == false)
            {
                int bean = 1; 
                Console.WriteLine("please enter a valid numbers");
                return bean; 
            }
            else
            {
                int bean2 = 2;
                return bean2;
            }
            
        }
        
    

    }
}
