using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anders_os
{
    internal class SwitchCommands
    {
        public static void switchCommands(string input)
        {
            switch (input)
            {
                case "":
                    break;
                case "--help":
                    Commands.help();
                    break;
                case "--about":
                    Commands.about();
                    break;
                case "--name":
                    Commands.name();
                    break;
                case "--author":
                    Commands.author();
                    break;
                case "--version":
                case "--ver":
                    Commands.version();
                    break;
                case "clear":
                    Commands.clear();
                    break;
                case "time":
                    Commands.time();
                    break;
                case "sum":
                    Commands.sum();
                    break;
                case "minus":
                    Commands.minus();
                    break;
                case "reboot":
                    Commands.reboot();
                    break;
                case "shutdown":
                    Commands.shutdown();
                    break;
                default:
                    Console.WriteLine("The command is invalid");
                    break;
            }
        }
    }
}
