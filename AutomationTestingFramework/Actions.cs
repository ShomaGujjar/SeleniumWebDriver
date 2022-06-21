using AutomationTestingFramework.UIElements;
using OpenQA.Selenium.Chrome;

namespace AutomationTestingFramework
{
    public static class Actions
    {
        public static void InitializeDriver()
        {
            Driver.driver = new ChromeDriver();
            Driver.driver.Navigate().GoToUrl(Config.BaseURL);
        }

        public static void FillLoginForm(string userName, string password, string repeatPassword)
        {
            LoginScenarioPost loginScenarioPost = new LoginScenarioPost();

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
