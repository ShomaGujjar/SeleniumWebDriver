using AutomationTestingFramework.UIElements;

namespace AutomationTestingFramework
{
    public static class Actions
    {
        public static void InitializeDriver()
        {
            Driver.driver.Navigate().GoToUrl(Config.BaseURL);
        }
        public static void FillLoginForm(string userName, string password, string repeatPassword)
        {
            LoginScenarioPost loginScenarioPost = new LoginScenarioPost();
            loginScenarioPost.UserName.SendKeys(userName);
            loginScenarioPost.Password.SendKeys(password);
            loginScenarioPost.RepeatPassword.SendKeys(repeatPassword);
            loginScenarioPost.LoginButton.Click();
        }

    }
}
