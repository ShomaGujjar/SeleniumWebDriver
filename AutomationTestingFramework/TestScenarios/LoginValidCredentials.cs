using NUnit.Framework;
using OpenQA.Selenium;

namespace AutomationTestingFramework.TestScenarios
{
    [Parallelizable]
    //[Parallelizable(ParallelScope.None)] - to exclude the test from the Parallelizable scope
    public class LoginValidCredentials
    {
        IAlert _alert;
        public IWebDriver Driver { get; set; }

        [OneTimeSetUp]
        public void Initialize()
        {
            Driver = Actions.InitializeDriver();
        }

        [Test]
        public void ValidLogin()
        {
            //Navigate to login form through the Main Menu
            NavidateTo.LoginFormThroughTheMainMenu(Driver);

            Actions.FillLoginForm(Config.Credentials.Valid.UserName,
                Config.Credentials.Valid.Password, Config.Credentials.Valid.RepeatPassword, Driver);

            _alert = Driver.SwitchTo().Alert();

            Assert.AreEqual(Config.AlertMessages.SuccessfulLogin, _alert.Text);

            _alert.Accept();
        }


        [OneTimeTearDown]
        public void Cleanup()
        {
            Driver.Quit();
        }
    }
}
