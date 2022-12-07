using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sys = Cosmos.System;

namespace anders_os
{
    public class Kernel : Sys.Kernel
    {

        protected override void BeforeRun()
        {
            Console.Clear();
            Console.WriteLine(Variabels.welcome + "\n" + Variabels.about + "\n");
        }

        protected override void Run()
        {
            Console.Write(Variabels.prompt);
            var input = Console.ReadLine().ToLower();

            SwitchCommands.switchCommands(input);
        }
    }
}
