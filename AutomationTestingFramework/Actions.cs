using AutomationTestingFramework.UIElements;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationTestingFramework
{
    public static class Actions
    {
        public static IWebDriver InitializeDriver()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Config.BaseURL);
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            return driver;
        }

        public static void FillLoginForm(string userName, string password, string repeatPassword, IWebDriver driver)
        {
            LoginScenarioPost loginScenarioPost = new LoginScenarioPost(driver);

            loginScenarioPost.UserName.Clear();
            loginScenarioPost.Password.Clear();
            loginScenarioPost.RepeatPassword.Clear();

            loginScenarioPost.UserName.SendKeys(userName);
            loginScenarioPost.Password.SendKeys(password);
            loginScenarioPost.RepeatPassword.SendKeys(repeatPassword);
            loginScenarioPost.LoginButton.Click();
        }

    }
}
