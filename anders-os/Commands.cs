using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sys = Cosmos.System;

namespace anders_os
{
    public class Commands
    {
        public static void help()
        {
            const string msg = @"
***************************************************************
*  --help --------------- Show commands and descriptions      *
*  --about -------------- Show OS about                       *
*  --name --------------- Show OS name                        *
*  --author ------------- Show OS author                      *
*  --version ------------ Show OS version                     *
*                                                             *
*  clear ---------------- Clear the screen                    *
*  time ----------------- Show the current time               *
*  sum ------------------ Calculate the sum of two numbers    *
*  minus ---------------- Calculate the minus of two numbers  *
*  reboot --------------- Reboot the system                   *
*  shutdown ------------- Shutdown the system                 *
***************************************************************
            ";

            Console.WriteLine(msg);
        }

        public static void about()
        {
            Console.WriteLine(Variabels.about);
        }

        public static void name()
        {
            Console.WriteLine(Variabels.name);
        }

        public static void author()
        {
            Console.WriteLine(Variabels.author);
        }

        public static void version()
        {
            Console.WriteLine(Variabels.version);
        }

        public static void clear()
        {
            Console.Clear();
        }

        public static void time()
        {
            Console.WriteLine(DateTime.Now.ToLongTimeString());
        }

        public static void sum()
        {
            int x,y, sum;
            Console.WriteLine("Enter the first number: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            y = Convert.ToInt32(Console.ReadLine());

            sum = x + y;
            Console.WriteLine("The sum is equal to: " + sum);
        }

        public static void minus()
        {
            int x, y, minus;
            Console.WriteLine("Enter the first number: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            y = Convert.ToInt32(Console.ReadLine());

            minus = x - y;
            Console.WriteLine("The minus is equal to: " + minus);
        }

        public static void reboot()
        {
            Sys.Power.Reboot();
        }

        public static void shutdown()
        {
            Sys.Power.Shutdown();
        }
    }
}
