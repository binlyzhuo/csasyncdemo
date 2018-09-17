using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chpt01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task is running~");
            DoSomethingAsync();
            Console.WriteLine("Task is complete~");
            Console.ReadLine();
            //await t;
        }

        static async void DoSomethingAsync()
        {
            int val = 13;
            await Task.Delay(TimeSpan.FromSeconds(1));
            val *= 2;
            await Task.Delay(TimeSpan.FromSeconds(1));
            Console.Write(val);
        }

        
    }
}
