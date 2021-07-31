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
        [ExpectedException(typeof(System.ArgumentNullException))]
        public void TestUserFirstName1()
        {
            var result = userregistrationvalidation.validatefisrtName(null);
        }

        [TestMethod]
        [ExpectedException(typeof(UserRegistrationCustomException))]
        public void TestUserFirstName2()
        {
            var result = userregistrationvalidation.validatefisrtName("pawan");
        }

        [TestMethod]
        [ExpectedException(typeof(UserRegistrationCustomException))]
        public void TestUserFirstName3()
        {
            var result = userregistrationvalidation.validatefisrtName("");
        }
        #endregion UC-1

        #region UC-2
        [TestMethod]
        [ExpectedException(typeof(UserRegistrationCustomException))]
        public void TestUserLastName1()
        {
            var result = userregistrationvalidation.validatelastName("gupta");
        }

        [TestMethod]
        [ExpectedException(typeof(UserRegistrationCustomException))]
        public void TestUserLastName2()
        {
            var result = userregistrationvalidation.validatelastName("");
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentNullException))]
        public void TestUserLastName3()
        {
            var result = userregistrationvalidation.validatelastName(null);
        }

        #endregion UC-2

        #region UC-3
        [TestMethod]
        public void TestUserEmailName()
        {
            var result = userregistrationvalidation.validateEmail("guptapawan767@gmail.com");
            Assert.AreEqual(true, result);
        }
        #endregion UC-3

        #region UC-4
        [TestMethod]
        public void TestUserPh_no()
        {
            var result = userregistrationvalidation.validatePh_No("91 8484053791");
            Assert.AreEqual(true, result);
        }
        #endregion UC-4
        
        #region UC 5-8
        [TestMethod]
        public void TestUserPassword()
        {
            var result = userregistrationvalidation.validatePassword("Pawan@1999");
            Assert.AreEqual(true, result);
        }
        #endregion UC 5-8

       
    }
}
