using Microsoft.VisualStudio.TestTools.UnitTesting;
using AllWorlds.Classes;

namespace ActorTest
{
    [TestClass]
    public class ActorTest
    {
        [TestMethod]
        public void TestNameValidation()
        {
            var actor = new Actor();
            actor.Name = "Player123";
            Assert.AreEqual("Player123", actor.Name);

            // Test invalid name with non-alphanumeric characters
            actor.Name = "Player@123";
            Assert.AreEqual("Player123", actor.Name); // Name should remain unchanged
        }

        [TestMethod]
        public void TestAttributeSetting()
        {
            var actor = new Actor();
            actor.SetAttribute(Actor.CharacterAttributes.Strength, 10);
            Assert.AreEqual(10, actor.GetAttribute(Actor.CharacterAttributes.Strength));

            // Test negative value
            actor.SetAttribute(Actor.CharacterAttributes.Strength, -5);
            Assert.AreEqual(0, actor.GetAttribute(Actor.CharacterAttributes.Strength)); // Should be clamped to 0
        }

        [TestMethod]
        public void TestShadowManagement()
        {
            var actor = new Actor();
            var shadow = new Shadow("buff1", 20, 5, 100);
            actor.AddShadow(shadow);

            // You may need to add a method to Actor to retrieve shadows for this test
            Assert.IsTrue(actor.ContainsShadow(shadow));
        }
    }
}