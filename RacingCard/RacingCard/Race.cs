using System;
using System.Threading;

namespace RacingCard
{
    public class Race
    {
        
        public static SemaphoreSlim race = new SemaphoreSlim(0);
        public static SemaphoreSlim end = new SemaphoreSlim(0);
        public void Run()
        {
            race.Wait();
            race.Wait();
            race.Wait();
            race.Wait();
            race.Wait();
            
            Start();
            Car.car.Release(5);
            end.Wait();
            end.Wait();
            end.Wait();
            end.Wait();
            end.Wait();
            End();
        }

        private void Start()
        {
            Console.WriteLine("Starting Race");
            Thread.Sleep(1000);
        }

        private void End()
        {
            Console.WriteLine("Race finished");
        }
    }
}