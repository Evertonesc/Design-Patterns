using DesignPatterns.BehavioralPatterns.StrategyPattern;

namespace DesignPatterns
{
    public static class BehavioralPatternsFactory
    {
        public static PublicTransportStrategy CreatePublicTransportStrategy() =>
            new PublicTransportStrategy();

        public static RoadStrategy CreateRoadStrategy() =>
            new RoadStrategy();

        public static WalkingStrategy CreateWalkingStrategy() =>
            new WalkingStrategy();
    }
}
