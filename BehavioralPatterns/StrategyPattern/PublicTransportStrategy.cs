using System;

namespace DesignPatterns.BehavioralPatterns.StrategyPattern
{
    public class PublicTransportStrategy : IRouterStrategy
    {
        public void ExecuteRouter(RouterEnum routerEnum)
        {
            Console.WriteLine("Executing public transport strategy algorithm...");
        }
    }
}
