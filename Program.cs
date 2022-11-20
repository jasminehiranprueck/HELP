using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Module9
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a list. similar to arrays except it does not have a predetermined size
            List<Orders> orders = new List<Orders>();

            WriteLine("Welcome to CakeBae!");
            WriteLine("For our applcation I will show out the menu of cake designs and decorations");
            WriteLine("you will only be able to pick one of each for the purposes of application");

            //create a character value and a counter variable for our while loop

            char moreItems = 'y';
            int counter = 0;

            //create our while loop
            while (moreItems == 'y')
            {
                WriteLine("Let's get the items for item {0}", counter + 1);

                collectOrder(ref orders);
                counter++;
                WriteLine("Would you like to continue y/n?");
                moreItems = Convert.ToChar(ReadLine());
            }//ends the while

           
        }
        public static void collectOrder(ref List<Orders> o)
        {
        //===================================>THESE ARE THE LINES THAT ARE CONFUSING ME!!!!!!!!!!
            var listOfDesign = File.ReadLines("Design.csv").Select(Line => new Design(line)).ToList();
            var listOfDecoration = File.ReadLine("Decorations.csv").Select(Line => new Decorations(line)).ToList();

            WriteLine("Name for this Order Item: ");
            string name = ReadLine();

            //create a foreach loop to iterate through our list of designs
            WriteLine("Which design would you like?: ");
            foreach (Design d in listOfDesign)
            {
                //use the \t character which will space out the data
                WriteLine($"{d.DesignID}\t{d.DesignName}");

                //read the users input and get the design from the listOfDesign
                int a = Convert.ToInt32(ReadLine());
                string design = listOfDesign[a - 1].DesignName;
            }
        }
    }
}
