using System;
using System.Threading;

namespace ProducerConsumer
{
    class Program
    {
        static DateTime _start;
        static void Main(string[] args)
        {
            _start = DateTime.Now;
            Console.WriteLine("Production started at: " + _start.ToLongTimeString());
            for (int i = 0; i < 100; i++) {
                Produce(i);
            }
            var _end = DateTime.Now;
            Console.WriteLine("Consumption ended at: " + _end.ToLongTimeString());
            Console.WriteLine((_end - _start).TotalMilliseconds);

        }

        static void Produce(int index) {
            var message = "Message No " + index;
            Consume(message);
        }

        static void Consume(string message) {
            Thread.Sleep(500);
            Console.WriteLine(message);
        }
    }
}
