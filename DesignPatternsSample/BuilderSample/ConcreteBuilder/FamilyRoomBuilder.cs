using DesignPatternsSample.BuilderSample.BuilderInterface;

namespace DesignPatternsSample.BuilderSample
{
    internal class FamilyRoomBuilder : IRoomBuilder
    {
        public Room Build()
        {
            return new Room("Family")
                .WithBalcony()
                .WithWiFi()
                .WithBed(3);
        }
    }
}