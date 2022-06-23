using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

public class Program
{
    static void Main()
    {
        IWebDriver driver = new ChromeDriver();
        string url = "https://testing.todorvachev.com/";
        driver.Navigate().GoToUrl(url);

        IWebElement image = driver.FindElement(By.CssSelector("#page-17 > div > p:nth-child(1) > a > img"));

        driver.Manage().Window.Maximize();
        Console.WriteLine(image.Location.X);
        Console.WriteLine(image.Location.Y);
        Console.WriteLine(image.Size.Height);
        Console.WriteLine(image.Size.Width);

        IWebElement content = driver.FindElement(By.CssSelector("#page-17 > div"));

        SetStyle(driver, image, "display", "none");
        SetStyle(driver, content, "color", "blue");
        driver.Quit();
    }

    static void SetStyle(IWebDriver driver, IWebElement element, string style, string styleValue)
    {
        IJavaScriptExecutor javaScriptExecutor = (IJavaScriptExecutor)driver;

        string imageScript = $"arguments[0].style[\"{style}\"]=\"{styleValue}\"";

        javaScriptExecutor.ExecuteScript(imageScript, element);
    }
}
