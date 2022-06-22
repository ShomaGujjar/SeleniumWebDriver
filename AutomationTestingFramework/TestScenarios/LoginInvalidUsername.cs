using NUnit.Framework;
using OpenQA.Selenium;

namespace AutomationTestingFramework.TestScenarios
{
    [Parallelizable]
    public class LoginInvalidUsername
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
            Actions.FillLoginForm(Config.Credentials.Invalid.UserName.FourCharacters,
                Config.Credentials.Valid.Password, Config.Credentials.Valid.RepeatPassword);

            _alert = Driver.driver.SwitchTo().Alert();

            Assert.AreEqual(Config.AlertMessages.UsernameLengthOutOfRange, _alert.Text);

            _alert.Accept();
        }

        [Test]
        public void MoreThan12Characters()
        {
            Actions.FillLoginForm(Config.Credentials.Invalid.UserName.ThirteenCharacters,
                Config.Credentials.Valid.Password, Config.Credentials.Valid.RepeatPassword);

            _alert = Driver.driver.SwitchTo().Alert();

            Assert.AreEqual(Config.AlertMessages.UsernameLengthOutOfRange, _alert.Text);

            _alert.Accept();
        }


        [OneTimeTearDown]
        public void Cleanup()
        {
            Driver.driver.Quit();
        }
    }
}
