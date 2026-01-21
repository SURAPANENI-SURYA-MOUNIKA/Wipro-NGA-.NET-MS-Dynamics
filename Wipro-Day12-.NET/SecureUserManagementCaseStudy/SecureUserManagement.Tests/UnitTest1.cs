//using NUnit.Framework;
using SecureUserManagementCaseStudy.Services;

namespace SecureUserManagement.Tests
{
    public class UnitTest1
    {
            [Test]
            public void RegisterAndLogin_ShouldPass()
            {
                AuthService service = new AuthService();
                service.Register("test", "123");

                bool result = service.Authenticate("test", "123");

                Assert.IsTrue(result);
            }

            [Test]
            public void Login_WithWrongPassword_ShouldFail()
            {
                AuthService service = new AuthService();
                service.Register("test", "123");

                bool result = service.Authenticate("test", "wrong");

                Assert.IsFalse(result);
            }
        }
    }
