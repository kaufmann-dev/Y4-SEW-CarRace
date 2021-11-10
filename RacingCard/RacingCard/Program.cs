using System;
using System.Threading;

namespace RacingCard
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread car_1 = new Thread(() => new Car().Run());
            Thread car_2 = new Thread(() => new Car().Run());
            Thread car_3 = new Thread(() => new Car().Run());
            Thread car_4 = new Thread(() => new Car().Run());
            Thread car_5 = new Thread(() => new Car().Run());
            
            Thread race = new Thread(() => new Race().Run());
            
            car_1.Start();
            car_2.Start();
            car_3.Start();
            car_4.Start();
            car_5.Start();
            
            race.Start();
        }
    }
}