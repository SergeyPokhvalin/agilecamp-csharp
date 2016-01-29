using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace AFT
{
    // PageObjects pattern https://code.google.com/p/selenium/wiki/PageObjects

    public class LoginUiTest
    {
        private readonly string EmailIsNotValidMessage = "The Email field is not a valid e-mail address.";

        [Test]
        public void IfEmailAddressIsNotValid_ShowValidationMessage()
        {
            using (var driver = new ChromeDriver())
            {
                var displayMessage = new LoginPage(driver)
                    .Navigate()
                    .SublitButtonClick()
                    .GetloginErrorMessage()
                    .Displayed;
                Assert.True(displayMessage);
            }
        }

        [Test]
        public void IfEmailAddressIsValid_ShowValidationMessage()
        {
            using (var driver = new ChromeDriver())
            {
                var errorMessage = new LoginPage(driver)
                    .Navigate()
                    .SetEmailField("testemail")
                    .SublitButtonClick()
                    .GetloginErrorMessage()
                    .Text;
          
                Assert.AreEqual(EmailIsNotValidMessage, errorMessage);
            }
        }
    }
}