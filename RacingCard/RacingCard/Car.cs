using System;
using System.Threading;

namespace RacingCard
{
    public class Car
    {
        public static SemaphoreSlim car = new SemaphoreSlim(0);
        public static SemaphoreSlim box = new SemaphoreSlim(3);
        public void Run()
        {
            WaitForSignal();
            Race.race.Release();
            car.Wait();
            
            
            Racing();

            box.Wait();
            TakingPitstop();
            box.Release();
            
            Racing();
            Race.end.Release();
        }
        private void WaitForSignal(){
            Console.WriteLine("Waiting for Start Signal");
            Thread.Sleep(300); 
        }
        
        private void Racing(){
            Console.WriteLine("Racing");
            Thread.Sleep(800);
        }
        
        private void TakingPitstop(){
            Console.WriteLine("Taking Pitstop");
            Thread.Sleep(800);
        }
    }
}