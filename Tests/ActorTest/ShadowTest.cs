using Microsoft.VisualStudio.TestTools.UnitTesting;
using AllWorlds.Classes;

namespace ActorTest
{
    [TestClass]
    public class ShadowTest
    {
        [TestMethod]
        public void TestShadowCreation()
        {
            var shadow = new Shadow("buff1", 20, 5, 100);
            Assert.AreEqual("buff1", shadow.Name);
            Assert.AreEqual(20, shadow.Level);
            Assert.AreEqual(5, shadow.Bonus);
            Assert.AreEqual(100, shadow.Duration);
        }

        [TestMethod]
        public void TestShadowValidation()
        {
            var shadow = new Shadow("buff1", 20, 5, 100);

            // Test negative value
            shadow.Level = -10;
            Assert.AreEqual(0, shadow.Level); // Should be clamped to 0

            // Test empty name
            shadow.Name = "";
            Assert.AreEqual("buff1", shadow.Name); // Name should remain unchanged
        }
    }
}