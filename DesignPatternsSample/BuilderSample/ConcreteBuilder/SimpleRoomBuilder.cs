using DesignPatternsSample.BuilderSample.BuilderInterface;

namespace DesignPatternsSample.BuilderSample
{
    internal class SimpleRoomBuilder : IRoomBuilder
    {
        public Room Build()
        {
            return new Room("Simple")
                .WithBed(1);
        }
    }
}