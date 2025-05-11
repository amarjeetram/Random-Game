using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace math
{
    class Program
    {
        public void colorstru()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("<========WELCOME TO GUSSING GAME=====>");
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("--------MADE BY AMARTRO--------");
        }
        public void mathrandom()
        {
          
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Enter your  number");
            int usernum = Convert.ToInt32(Console.ReadLine());
            Random rnd = new Random();
            int random = rnd.Next(1,10);
            if (usernum == random)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("you win");
                exitornot();
               
            }
            if (usernum > random)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("your number is bigger");
                exitornot();


            }
            else if (usernum < random)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("Random number is bigger");
                exitornot();

            }
    
                          
            mathrandom();
        }
        public void exitornot()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("1 Exit");
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("2 Continue");

            int userinput = Convert.ToInt32(Console.ReadLine());

            if (userinput == 1)
            {
                Environment.Exit(0);
            }
            if (userinput == 2)
            {
                mathrandom();
            }
            else
            {
                Console.WriteLine("Enter correct option");
                exitornot();
            }
        }
        
        static void Main(string[] args)
        {
            Program m = new Program();
            m.colorstru();
            m.mathrandom();
            
            Console.ReadLine();

        }
    }
}
