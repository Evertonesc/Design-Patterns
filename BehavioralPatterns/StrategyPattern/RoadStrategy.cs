using System;

namespace DesignPatterns.BehavioralPatterns.StrategyPattern
{
    public class RoadStrategy : IRouterStrategy
    {
        public void ExecuteRouter(RouterEnum routerEnum)
        {
            Console.WriteLine("Executing walking strategy algorithm...");
        }
    }
}
