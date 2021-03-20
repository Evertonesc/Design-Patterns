using System;

namespace DesignPatterns.BehavioralPatterns.StrategyPattern
{
    public static class Strategy
    {
        public static void ExecuteStrategyPattern()
        {
            var randomRoute = new Random();
            var route = randomRoute.Next(1, 3);
            var selectedRoute = (RouterEnum)route;

            Console.WriteLine("Creating strategy context...");
            var strategyContext = new StrategyContext();

            if (selectedRoute == RouterEnum.PublicTransport)
                strategyContext.SetStrategy(BehavioralPatternsFactory.CreatePublicTransportStrategy());

            if (selectedRoute == RouterEnum.Road)
                strategyContext.SetStrategy(BehavioralPatternsFactory.CreateRoadStrategy());

            if (selectedRoute == RouterEnum.Walking)
                strategyContext.SetStrategy(BehavioralPatternsFactory.CreateWalkingStrategy());

            strategyContext.ExecuteStrategy(selectedRoute);
            Console.WriteLine("Ending...");
        }
    }
}
