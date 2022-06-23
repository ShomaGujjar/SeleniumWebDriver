using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AutomationTestingFramework.UIElements
{
    public class UserNameFieldPost
    {
        public UserNameFieldPost(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#post-74 > div > p > a")]
        public IWebElement LoginFormLink { get; set; }
    }
}
