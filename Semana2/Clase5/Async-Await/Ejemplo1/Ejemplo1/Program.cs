using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    public class Program
    {
        public static async Task process1()
        {
            await Task.Run(() =>
            {
                for(int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Process 1");
                    Task.Delay(100).Wait();
                }
            });
        }

        public static void process2()
        {
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Process 2");
                Task.Delay(100).Wait();
            }
        }
        static void Main(string[] args)
        {
            process1();
            process2();
            Console.ReadKey();
        }
    }
}
