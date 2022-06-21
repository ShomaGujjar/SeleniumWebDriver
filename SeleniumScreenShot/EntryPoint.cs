using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumScreenShot
{
    public class EntryPoint
    {
        static void Main()
        {
            IWebDriver driver = new ChromeDriver();
            string screenShotDirectory = "Directory.GetCurrentDirectory()" + @"\screenshots";
            driver.Navigate().GoToUrl("http://google.com");

            Screenshot googleScreenshot = ((ITakesScreenshot)driver).GetScreenshot();

            if (!Directory.Exists(screenShotDirectory))
            {
                Directory.CreateDirectory(screenShotDirectory);
            }

            googleScreenshot.SaveAsFile(Directory.GetCurrentDirectory() + @"\screenshots\googlescreenshot.png", ScreenshotImageFormat.Png);
            driver.Quit();
        }

    }
}
