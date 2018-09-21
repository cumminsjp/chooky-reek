using System.Reflection;
using Common.Logging;
using NUnit.Framework;

namespace Va.Dcr.Bmp.Tests
{
    /// <summary>
    // Exporter tests
    /// </summary>
    [TestFixture]
    public class BaseTestClass
    {
        /// <summary>
        ///     SetUp is called once before each Test within the same TestFixture
        /// </summary>
        //[SetUp]
        //public void BaseSetUp()
        //{
        //    Log.Debug("Enter");
        //}

        /// <summary>
        /// SetUp is called once after each Test within the same TestFixture
        /// </summary>
        //[TearDown]
        //public void BaseTearDown()
        //{
        //    Log.Debug("Enter");
        //}

        /// <summary>
        ///     The Log (Common.Logging)
        /// </summary>
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);



        /// <summary>
        /// Test that does nothing. Functions as a control test for testing frameworks.
        /// </summary>
        [Test]
        public void EmptyTest()
        {
        }
    }
}