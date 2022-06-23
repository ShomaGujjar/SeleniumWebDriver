using NUnit.Framework;
using OpenQA.Selenium;

namespace AutomationTestingFramework.TestScenarios
{
    [Parallelizable]
    public class LoginInvalidPassword
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
            try
            {
                Actions.FillLoginForm(Config.Credentials.Valid.UserName,
                    Config.Credentials.Invalid.Password.FourCharacters,
                    Config.Credentials.Invalid.Password.FourCharacters, Driver);

                _alert = Driver.SwitchTo().Alert();

                Assert.AreEqual(Config.AlertMessages.PasswordLengthOutOfRange, _alert.Text);

                _alert.Accept();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }

        [Test]
        public void MoreThan12Characters()
        {
            Actions.FillLoginForm(Config.Credentials.Valid.UserName,
                Config.Credentials.Invalid.Password.ThirteenCharacters,
                Config.Credentials.Invalid.Password.ThirteenCharacters, Driver);

            _alert = Driver.SwitchTo().Alert();

            Assert.AreEqual(Config.AlertMessages.PasswordLengthOutOfRange, _alert.Text);

            _alert.Accept();
        }


        [OneTimeTearDown]
        public void Cleanup()
        {
            Driver.Quit();
        }
    }
}
