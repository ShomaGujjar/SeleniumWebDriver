using NUnit.Framework;
using OpenQA.Selenium;

namespace AutomationTestingFramework.TestScenarios
{
    public class LoginInvalidPassword
    {
        IAlert _alert;

        [OneTimeSetUp]
        public void Initialize()
        {
            Actions.InitializeDriver();
            NavidateTo.LoginFormThroughTheMainMenu();
        }

        [Test]
        public void LessThan5Characters()
        {
            Actions.FillLoginForm(Config.Credentials.Valid.UserName,
                Config.Credentials.Invalid.Password.FourCharacters, Config.Credentials.Invalid.Password.FourCharacters);

            _alert = Driver.driver.SwitchTo().Alert();

            Assert.AreEqual(Config.AlertMessages.PasswordLengthOutOfRange, _alert.Text);

            _alert.Accept();
        }

        [Test]
        public void MoreThan12Characters()
        {
            Actions.FillLoginForm(Config.Credentials.Valid.UserName,
                Config.Credentials.Invalid.Password.ThirteenCharacters, Config.Credentials.Invalid.Password.ThirteenCharacters);

            _alert = Driver.driver.SwitchTo().Alert();

            Assert.AreEqual(Config.AlertMessages.PasswordLengthOutOfRange, _alert.Text);

            _alert.Accept();
        }


        [OneTimeTearDown]
        public void Cleanup()
        {
            Driver.driver.Quit();
        }
    }
}
