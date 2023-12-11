using NUnit.Framework;
using System.Text.Json;

namespace LT.DigitalOffice.UnitTestKernel
{
    /// <summary>
    /// Helper class that allows you to compare two complex objects.
    /// </summary>
    public static class SerializerAssert
    {
        /// <summary>
        /// Check that objects are equal.
        /// </summary>
        public static void AreEqual(object expected, object result)
        {
            string expectedJson = JsonSerializer.Serialize(expected);
            string resultJson = JsonSerializer.Serialize(result);

            Assert.That(resultJson, Is.EqualTo(expectedJson));
        }

        /// <summary>
        /// Check that objects are not equal.
        /// </summary>
        public static void AreNotEqual(object expected, object result)
        {
            string expectedJson = JsonSerializer.Serialize(expected);
            string resultJson = JsonSerializer.Serialize(result);

            Assert.That(resultJson, Is.EqualTo(expectedJson));
        }
    }
}
