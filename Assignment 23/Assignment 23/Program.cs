using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_23
{
    internal class Program
    {
  
        
            public delegate void SpinDelegate(ref int energyLevel, ref int winningProbability);

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Name:");
            string playerName = Console.ReadLine();

            Console.WriteLine("Enter Your Lucky Number from 1 to 10:");
            int luckyNumber = Convert.ToInt32(Console.ReadLine());

            int energyLevel = 1;
            int winningProbability = 100;
            int numberOfSpins = 5;

            SpinDelegate spinDelegate = null;
            spinDelegate += Spin;
            spinDelegate += Spin;
            spinDelegate += Spin;
            spinDelegate += Spin;
            spinDelegate += Spin;
            spinDelegate += Spin;
            spinDelegate += Spin;
            spinDelegate += Spin;
            spinDelegate += Spin;
            spinDelegate += Spin;

            for (int i = 0; i < numberOfSpins; i++)
            {
                spinDelegate(ref energyLevel, ref winningProbability);
            }

            Console.WriteLine("Winner:");
            if (energyLevel >= 4 && winningProbability > 60)
            {
                Console.WriteLine($"{playerName} is the winner!");
            }
            else if (energyLevel >= 1 && winningProbability > 50)
            {
                Console.WriteLine($"{playerName} is the runner up!");
            }
            else
            {
                Console.WriteLine($"{playerName} is the loser!");
            }
        }

        public static void Spin(ref int energyLevel, ref int winningProbability)
        {
            energyLevel += 1;
            winningProbability += 10;
        }
    }
}
    
