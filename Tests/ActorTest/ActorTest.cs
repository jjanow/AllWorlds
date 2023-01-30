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

            actor.SetRace(Actor.races.elf);

            Assert.AreEqual(actor.GetRace(), "elf");
        }
    }
}
