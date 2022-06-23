using AutomationTestingFramework.UIElements;
using OpenQA.Selenium;

namespace AutomationTestingFramework
{
    public static class NavidateTo
    {
        public static void LoginFormThroughTheMainMenu(IWebDriver driver)
        {
            Menu menu = new Menu(driver);
            TestScenariosPage testScenariosPage = new TestScenariosPage(driver);

            menu.TestScenarios.Click();
            testScenariosPage.LoginForm.Click();
        }

        public static void LoginFormThroughThePost(IWebDriver driver)
        {
            Menu menu = new Menu(driver);
            TestCases testCases = new TestCases(driver);
            UserNameFieldPost testUserNameFieldPost = new UserNameFieldPost(driver);
            menu.TestCases.Click();
            testCases.UserNameInLoginForm.Click();
            testUserNameFieldPost.LoginFormLink.Click();
        }
    }
}
