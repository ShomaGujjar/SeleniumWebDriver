using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AutomationTestingFramework.UIElements
{
    public class LoginScenarioPost
    {
        public LoginScenarioPost()
        {
            PageFactory.InitElements(Driver.driver,this);
        }

        [FindsBy(How=How.CssSelector,Using = "#post-72 > div > form > ul > li:nth-child(2) > input[type=text]")]
        public IWebElement UserName { get; set; }

        [FindsBy(How=How.CssSelector,Using = "#post-72 > div > form > ul > li:nth-child(4) > input[type=password]")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.Name, Using = "repeatpassid")]
        public IWebElement RepeatPassword { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#post-72 > div > form > ul > li:nth-child(7) > input[type=submit]")]
        public IWebElement LoginButton { get; set; }
    }
}
