
    using NUnit.Framework;
using SecureUserManagementCaseStudy.Services;

namespace SecureManagementTestProject1
{
   
        public class UnitTest1
        {
            [Test]
            public void RegisterAndLogin_ShouldReturnTrue()
            {
               AuthService service = new AuthService();

                service.Register("testuser", "123");

                bool result = service.Authenticate("testuser", "123");

                Assert.IsTrue(result);
            }

            [Test]
            public void Login_WithWrongPassword_ShouldFail()
            {
                AuthService service = new AuthService();

                service.Register("testuser", "123");

                bool result = service.Authenticate("testuser", "wrong");

                Assert.IsFalse(result);
            }
        }
    }
