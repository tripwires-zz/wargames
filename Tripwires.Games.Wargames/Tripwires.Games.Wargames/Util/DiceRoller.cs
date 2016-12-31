using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Tripwires.Games.Wargames.Lib.Util
{
    public class DiceRoller
    {

        private int numberOfDice;
        private int sides;
        public int Sides
        {
            get
            {
                return sides;
            }
        }
        //http://stackoverflow.com/questions/767999/random-number-generator-only-generating-one-random-number
        private RNGCryptoServiceProvider cryptoService;
        private DiceRoller()
        {

        }

        /// <summary>
        /// iniates an instance of the DiceRoller class with default values (1 roll and a 100 sided die)
        /// </summary>
        /// <returns>an instance of the DiceRoller class</returns>
        public static DiceRoller Initiate()
        {
            return new DiceRoller() { numberOfDice = 1, sides = 100,cryptoService=new RNGCryptoServiceProvider() };
        }
        
        /// <summary>
        /// initiates an instandce of the DiceRoller class with a give value for the number of rolls and the number of sides the di(c)e should have
        /// </summary>
        /// <param name="numberOfDice">the number of dice</param>
        /// <param name="sides">The number of sides the die needs to have</param>
        /// <returns></returns>
        public static DiceRoller Initiate(int numberOfDice, int sides)
        {
            return new DiceRoller() { numberOfDice = numberOfDice, sides = sides, cryptoService = new RNGCryptoServiceProvider() };
        }
        
        /// <summary>
        /// roll the dice
        /// </summary>
        /// <returns>the results of the dice</returns>
        public int[] Roll()
        {
            int[] results = new int[numberOfDice + 1];
            for (int i = 0; i < numberOfDice; i++)
            {
                byte[] rng = new byte[1];
                do
                {
                    cryptoService.GetBytes(rng);
                } while (rng[0] > this.Sides && rng[0] != 0);
                results[i] = rng[0];
            }
            return results;
        }
    }
}
