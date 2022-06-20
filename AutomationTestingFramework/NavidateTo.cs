using AutomationTestingFramework.UIElements;

namespace AutomationTestingFramework
{
    public static class NavidateTo
    {
        public static void LoginFormThroughTheMainMenu()
        {
            Menu menu = new Menu();
            TestScenariosPage testScenariosPage = new TestScenariosPage();

            menu.TestScenarios.Click();
            testScenariosPage.LoginForm.Click();
        }

        public static void LoginFormThroughThePost()
        {
            Menu menu = new Menu();
            TestCases testCases = new TestCases();
            UserNameFieldPost testUserNameFieldPost = new UserNameFieldPost();
            menu.TestCases.Click();
            testCases.UserNameInLoginForm.Click();
            testUserNameFieldPost.LoginFormLink.Click();
        }
    }
}
