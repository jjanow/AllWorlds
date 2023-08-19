using Microsoft.VisualStudio.TestTools.UnitTesting;
using AllWorlds.Classes;

namespace ActorTest
{
    [TestClass]
    public class ActorTest
    {
        [TestMethod]
        public void ActorTestValid()
        {
            var actor = new Actor();
            actor.Race = Actor.races.elf; // Use the Race property instead of SetRace method
            Assert.AreEqual(actor.Race, "elf");
        }
    }
}