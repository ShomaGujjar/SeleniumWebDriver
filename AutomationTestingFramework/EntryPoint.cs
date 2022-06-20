using NUnit.Framework;
using OpenQA.Selenium;

namespace AutomationTestingFramework
{
    public class EntryPoint
    {
        IAlert alert;

        [SetUp]
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

            alert = Driver.driver.SwitchTo().Alert();

            Assert.AreEqual(Config.AlertMessages.SuccessfulLogin, alert.Text);

            alert.Accept();
        }


        [TearDown]
        public void Cleanup()
        {
            Driver.driver.Quit();
        }
    }
}
