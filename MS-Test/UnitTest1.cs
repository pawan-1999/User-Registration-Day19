using User_Registration_Day19;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace MS_Test
{
    [TestClass]
    public class UnitTest1
    {
        private readonly UserRegistrationValidation userregistrationvalidation;
        public UnitTest1()
        {
            userregistrationvalidation = new UserRegistrationValidation();
        }
        #region UC-1
        [TestMethod]
        public void TestUserFirstName()
        {
            var result = userregistrationvalidation.validatefisrtName("Pawan");
            Assert.AreEqual(true, result);
        }
        #endregion UC-1

    }
}
