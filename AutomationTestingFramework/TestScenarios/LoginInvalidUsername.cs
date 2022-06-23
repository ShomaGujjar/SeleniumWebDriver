using NUnit.Framework;
using OpenQA.Selenium;

namespace AutomationTestingFramework.TestScenarios
{
    [Parallelizable]
    public class LoginInvalidUsername
    {
        IAlert _alert;
        public IWebDriver Driver { get; set; }

        [OneTimeSetUp]
        public void Initialize()
        {
            Driver = Actions.InitializeDriver();
            NavidateTo.LoginFormThroughTheMainMenu(Driver);
        }

        [Test]
        public void LessThan5Characters()
        {
            Actions.FillLoginForm(Config.Credentials.Invalid.UserName.FourCharacters,
                Config.Credentials.Valid.Password, Config.Credentials.Valid.RepeatPassword, Driver);

            _alert = Driver.SwitchTo().Alert();

            Assert.AreEqual(Config.AlertMessages.UsernameLengthOutOfRange, _alert.Text);

            _alert.Accept();
        }

        [Test]
        public void MoreThan12Characters()
        {
            Actions.FillLoginForm(Config.Credentials.Invalid.UserName.ThirteenCharacters,
                Config.Credentials.Valid.Password, Config.Credentials.Valid.RepeatPassword, Driver);

            _alert = Driver.SwitchTo().Alert();

            Assert.AreEqual(Config.AlertMessages.UsernameLengthOutOfRange, _alert.Text);

            _alert.Accept();
        }


        [OneTimeTearDown]
        public void Cleanup()
        {
            Driver.Quit();
        }
    }
}
