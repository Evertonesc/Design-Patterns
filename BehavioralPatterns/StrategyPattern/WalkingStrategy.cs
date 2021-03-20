using System;

namespace DesignPatterns.BehavioralPatterns.StrategyPattern
{
    public class WalkingStrategy : IRouterStrategy
    {
        public void ExecuteRouter(RouterEnum routerEnum)
        {
            Console.WriteLine("Executing walking strategy algorithm...");
        }
    }
}
