//CODE FESTIVAL 2017 Final
//C. Time Gap
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputMax = int.Parse(Console.ReadLine());
            string[] inputs = Console.ReadLine().Split(' ');
            int[] d = new int[inputMax];
            for (int i = 0; i < inputMax; i++)
            {
                d[i] = int.Parse(inputs[i]);
            }
            Array.Sort(d);
            int[] placeTimes = new int[inputMax + 1];
            placeTimes[0] = 0;
            int placeTimeMax = 1;
            int clockWiseMin = int.MaxValue, counterClockWiseMin = int.MaxValue;
            for (int i = 0; i < inputMax; i++)
            {
                clockWiseMin = int.MaxValue;
                int[] placeTimesTest = new int[placeTimeMax + 1];
                Array.Copy(placeTimes, placeTimesTest, placeTimeMax);
                placeTimesTest[placeTimeMax] = d[i];
                Array.Sort(placeTimesTest);
                for (int j = 0; j < placeTimeMax; j++)
                {
                    clockWiseMin = Math.Min(clockWiseMin, Math.Abs(placeTimesTest[j + 1] - placeTimesTest[j]));
                }
                clockWiseMin = Math.Min(clockWiseMin, Math.Abs(24 - placeTimesTest[placeTimeMax]));

                counterClockWiseMin = int.MaxValue;
                placeTimesTest = new int[placeTimeMax + 1];
                Array.Copy(placeTimes, placeTimesTest, placeTimeMax);
                placeTimesTest[placeTimeMax] = 24-d[i];
                Array.Sort(placeTimesTest);
                for (int j = 0; j < placeTimeMax; j++)
                {
                    counterClockWiseMin = Math.Min(counterClockWiseMin, Math.Abs(placeTimesTest[j + 1] - placeTimesTest[j]));
                }
                counterClockWiseMin = Math.Min(counterClockWiseMin, Math.Abs(24 - placeTimesTest[placeTimeMax]));

                if (clockWiseMin > counterClockWiseMin)
                {
                    placeTimes[placeTimeMax] = d[i];
                }
                else
                {
                    placeTimes[placeTimeMax] = 24-d[i];
                }
                Array.Sort(placeTimes,0, placeTimeMax+1);
                placeTimeMax++;
                if (Math.Max(clockWiseMin, counterClockWiseMin) == 0)
                {
                    Console.WriteLine(0);
                    return;
                }
            }
            Console.WriteLine(Math.Max(clockWiseMin, counterClockWiseMin));
        }
    }
}