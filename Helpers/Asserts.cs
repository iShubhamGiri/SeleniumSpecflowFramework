using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SeleniumSpecflowFramework.Helpers
{
    public static class AssertHelper
    {
        public static void AreEqual(string expected, string actual)
        {
            Assert.AreEqual(expected, actual);
        }
    }
}
