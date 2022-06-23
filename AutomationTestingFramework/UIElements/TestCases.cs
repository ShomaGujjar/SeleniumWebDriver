using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AutomationTestingFramework.UIElements
{
    public class TestCases
    {
        public TestCases(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#main-content > article.mh-loop-item.mh-clearfix.post-78.post.type-post.status-publish.format-standard.has-post-thumbnail.hentry.category-test-cases > div > header > h3 > a")]
        public IWebElement ItemsInCategoryDropDownMenu { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#main-content > article.mh-loop-item.mh-clearfix.post-76.post.type-post.status-publish.format-standard.has-post-thumbnail.hentry.category-test-cases > div > header > h3 > a")]
        public IWebElement LoginButtonInLoginForm { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#main-content > article.mh-loop-item.mh-clearfix.post-74.post.type-post.status-publish.format-standard.has-post-thumbnail.hentry.category-test-cases > div > header > h3 > a")]
        public IWebElement UserNameInLoginForm { get; set; }
    }
}
