using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tripwires.Games.Wargames.Lib.Business;
using Tripwires.Games.Wargames.Lib.Types;
using Tripwires.Games.Wargames.Lib.Util;

namespace DebugTests
{
    class Program
    {
        static void Main(string[] args)
        {
            TestDie();
            TestDie2();
            TestCity();

            Console.ReadLine();

        }

        private static void TestCity()
        {
            City test = new City("random");
            Console.WriteLine(test.State.ToString());
            Console.WriteLine(string.Format("{0}-{1}-{2}", test.Name, test.Days, test.State.ToString()));
            Console.WriteLine(test.Days);
            test.tick();
            test.tick();
            test.tick();
            test.tick();
            Console.WriteLine(string.Format("{0}-{1}-{2}", test.Name, test.Days, test.State.ToString()));
            Console.WriteLine(string.Format("{0}-{1}-{2}", test.Name, test.Days, test.State.ToString()));
            Console.WriteLine(test.Days);
            Console.WriteLine(string.Format("{0}-{1}-{2}",test.Name,test.Days,test.State.ToString()));
            test.State = Enums.CityState.Friendly;
            Console.WriteLine(string.Format("{0}-{1}-{2}", test.Name, test.Days, test.State.ToString()));
        }

        private static void TestDie()
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
        }

        private static void  TestDie2()
        {
            DiceRoller roller = DiceRoller.Initiate(1, 20);
            Console.WriteLine(roller.Roll()[0]);
            Console.WriteLine(roller.Roll()[0]);
            Console.WriteLine(roller.Roll()[0]);
            Console.WriteLine(roller.Roll()[0]);
            Console.WriteLine(roller.Roll()[0]);
            Console.WriteLine(roller.Roll()[0]);
            Console.WriteLine(roller.Roll()[0]);
            Console.WriteLine(roller.Roll()[0]);
        }
    }
}
