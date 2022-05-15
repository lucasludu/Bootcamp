using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsynSample
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            await MakeBreakfastAsync();


            Console.ReadKey();
        }

        #region Sync Methods

        static void MakeBreakfast()
        {
            Console.WriteLine("Adding 1 to 2 teastpoons of coffee to a mug...");
            var hotWater = BoilWater();
            var milk = HeatMilk();
            Pour(hotWater);
            Pour(milk);
            Console.WriteLine("Add sugar...");
            Console.WriteLine("Set table...");
            Console.WriteLine("Drink");
        }

        static string BoilWater()
        {
            Console.WriteLine("Boiling water started...");
            Console.WriteLine("Waiting for water to be hot...");

            Thread.Sleep(5000);
            Console.WriteLine("-Boiling water complete...");

            return "Hot water.";
        }

        static string HeatMilk()
        {
            Console.WriteLine("Heating milk started...");
            Console.WriteLine("Waiting for milk to be hot...");

            Thread.Sleep(3000);
            Console.WriteLine("-Heating milk complete...");

            return "Hot milk.";
        }

        static void Pour(string drink)
        {
            Console.WriteLine($"Pouring {drink} in mug...");
        }

        #endregion Sync Methods

        #region Async Methods

        async static Task<string> BoilWaterAsync()
        {
            Console.WriteLine("Boiling water started...");
            Console.WriteLine("Waiting for water to be hot...");

            await Task.Delay(5000);
            Console.WriteLine("-Boiling water complete...");

            return "Hot water.";
        }

        async static Task<string> HeatMilkAsync()
        {
            Console.WriteLine("Heating milk started...");
            Console.WriteLine("Waiting for milk to be hot...");

            await Task.Delay(3000);
            Console.WriteLine("-Heating milk complete...");

            return "Hot milk.";
        }
        async static Task MakeBreakfastAsync()
        {
            Console.WriteLine("Adding 1 to 2 teastpoons of coffee to a mug...");
            var boilingWater = BoilWaterAsync();
            var hotMilk = await HeatMilkAsync();
            Console.WriteLine("Add sugar...");
            Console.WriteLine("Set table...");

            var hotWater = await boilingWater;
            Pour(hotWater);
            Pour(hotMilk);
            Console.WriteLine("Drink");
        }

        #endregion Async Methods

    }
}
