using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace topic_5_ass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double earthweaight;
            int planet;

            Console.WriteLine("what planet would you like to fight on");
            Console.WriteLine("1. Venus 2. Mars 3. Jupiter 4. Saturn 5. Uranus 6. Neptune");
            planet = int.Parse(Console.ReadLine());
            Console.WriteLine("what is your earth weaight");
            earthweaight = double.Parse(Console.ReadLine());

            if (planet == 1)
            {
                Console.WriteLine("on venus your weaight would be  " + earthweaight * 0.78 + "LB");
                Console.WriteLine("you got this win your fight");




            }
            else if (planet == 2)
            {
                Console.WriteLine("on mars your weaight would be  " + earthweaight * 0.39 + "LB");
                Console.WriteLine("you got this win your fight");



            }
            else if (planet == 3)
            {


                Console.WriteLine("on jupiter your weaight would be " + earthweaight * 2.65 + "LB");
                Console.WriteLine("you got this win your fight");



            }
            else if ((planet == 4)){





                Console.WriteLine("on saturn your weaight would be " + earthweaight * 1.17 + "LB");
                Console.WriteLine("you got this win your fight");

            }

            else if (((planet == 5))){

                Console.WriteLine("on uranus your weaight would be " + earthweaight * 1.05 + "LB");


                Console.WriteLine("you got this win your fight");





            }
            else if (((planet == 6)))
            {



                Console.WriteLine("on neptune your weaight would be " + earthweaight * 1.23 + "LB");



                Console.WriteLine("you got this win your fight");


            }








        }
    }
}
