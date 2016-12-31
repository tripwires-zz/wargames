using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tripwires.Games.Wargames.Lib.Types;
using Tripwires.Games.Wargames.Lib.Util;

namespace DebugTests
{
    class Program
    {
        static void Main(string[] args)
        {
            DiceRoller roller = DiceRoller.Initiate();
            Console.WriteLine(roller.Roll()[0]);
            Console.WriteLine(roller.Roll()[0]);
            Console.WriteLine(roller.Roll()[0]);
            Console.WriteLine(roller.Roll()[0]);
            Console.WriteLine(roller.Roll()[0]);
            Console.WriteLine(roller.Roll()[0]);
            Console.WriteLine(roller.Roll()[0]);
            Console.WriteLine(roller.Roll()[0]);
            Console.WriteLine(roller.Roll()[0]);
            Console.WriteLine(roller.Roll()[0]);
            Console.WriteLine(roller.Roll()[0]);
            Console.WriteLine(roller.Roll()[0]);
            Console.WriteLine(roller.Roll()[0]);
            Console.WriteLine(roller.Roll()[0]);
            Console.WriteLine(roller.Roll()[0]);
            Console.WriteLine(roller.Roll()[0]);
            Console.WriteLine(roller.Roll()[0]);
            roller = DiceRoller.Initiate(1, 20);
            Console.WriteLine(roller.Roll()[0]);
            Console.WriteLine(roller.Roll()[0]);
            Console.WriteLine(roller.Roll()[0]);
            Console.WriteLine(roller.Roll()[0]);
            Console.WriteLine(roller.Roll()[0]);
            Console.WriteLine(roller.Roll()[0]);
            Console.WriteLine(roller.Roll()[0]);
            Console.WriteLine(roller.Roll()[0]);
            Console.WriteLine(roller.Roll()[0]);
            Console.WriteLine(roller.Roll()[0]);
            Console.WriteLine(roller.Roll()[0]);
            Console.WriteLine(roller.Roll()[0]);
            Console.WriteLine(roller.Roll()[0]);
            Console.WriteLine(roller.Roll()[0]);
            Console.WriteLine(roller.Roll()[0]);
            Console.WriteLine(roller.Roll()[0]);
            Console.WriteLine(roller.Roll()[0]);
            Console.ReadLine();
        }
    }
}
