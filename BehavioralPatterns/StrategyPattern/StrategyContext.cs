namespace DesignPatterns.BehavioralPatterns.StrategyPattern
{
    public class StrategyContext
    {
        private IRouterStrategy _routerStrategy;

        public void SetStrategy(IRouterStrategy routerStrategy) =>
            _routerStrategy = routerStrategy;

        public void ExecuteStrategy(RouterEnum routerEnum) =>
            _routerStrategy.ExecuteRouter(routerEnum);
    }
}
