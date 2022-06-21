using NUnit.Framework;
using OpenQA.Selenium;

namespace AutomationTestingFramework.TestScenarios
{
    public class LoginValidCredentials
    {
        IAlert _alert;

        [OneTimeSetUp]
        public void Initialize()
        {
            Actions.InitializeDriver();
        }

        [Test]
        public void ValidLogin()
        {
            //Navigate to login form through the Main Menu
            NavidateTo.LoginFormThroughTheMainMenu();

            Actions.FillLoginForm(Config.Credentials.Valid.UserName,
                Config.Credentials.Valid.Password, Config.Credentials.Valid.RepeatPassword);

            _alert = Driver.driver.SwitchTo().Alert();

            Assert.AreEqual(Config.AlertMessages.SuccessfulLogin, _alert.Text);

            _alert.Accept();
        }


        [OneTimeTearDown]
        public void Cleanup()
        {
            Driver.driver.Quit();
        }
    }
}
