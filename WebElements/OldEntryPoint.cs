using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WebElements
{
    static class OldEntryPoint
    {
        static readonly IWebDriver Driver = new ChromeDriver();
        static void OldMain()
        {
            DropDownMenu(Driver);
            RadioButton(Driver);
            CheckBox(Driver);
            SelectorByName(Driver);
            SelectorById(Driver);
            SelectorByClassName(Driver);
            SelectorByCssPath(Driver);
            InputTextBox(Driver);
            AlertBox(Driver);
            Thread.Sleep(3000);
            Driver.Quit();
        }

        public static void AlertBox(IWebDriver driver)
        {
            string url = "https://testing.todorvachev.com/alert-box/";
            driver.Navigate().GoToUrl(url);
            IAlert alert = driver.SwitchTo().Alert();
            Console.WriteLine(alert.Text);
            alert.Accept();
            IWebElement image = Driver.FindElement(By.CssSelector("#post-119 > div > figure > img"));
            try
            {
                if (image.Displayed)
                    GreenMessage("Image is visible!!");
            }
            catch (NoSuchElementException)
            {
                RedMessage($"Image not visible. Found an exception");
            }

        }

        public static void DropDownMenu(IWebDriver driver)
        {
            string url = "https://testing.todorvachev.com/drop-down-menu-test/";
            driver.Navigate().GoToUrl(url);

            IWebElement dropDownMenu = driver.FindElement(By.Name("DropDownTest"));
            var currentValue = dropDownMenu.GetAttribute("value");
            for (int i = 1; i <= 4; i++)
            {
                var dropDownMenuElementCssSelector = $"#post-6 > div > p:nth-child(6) > select > option:nth-child({i})";
                IWebElement dropDownMenuElement = driver.FindElement(By.CssSelector(dropDownMenuElementCssSelector));
                var elementValue = dropDownMenuElement.GetAttribute("value");
                Console.WriteLine($"Element {i} with Value={elementValue}");
            }

            Console.WriteLine(currentValue);
        }

        public static void InputTextBox(IWebDriver driver)
        {
            string url = "https://testing.todorvachev.com/text-input-field/";
            driver.Navigate().GoToUrl(url);
            IWebElement textBox = driver.FindElement(By.Name("username"));
            textBox.SendKeys("Test text");
            Console.WriteLine(textBox.GetAttribute("value"));
            Console.WriteLine(textBox.GetAttribute("maxlength"));
            textBox.Clear();//clears the text box contents
        }

        public static void RadioButton(IWebDriver driver)
        {
            string url = "https://testing.todorvachev.com/radio-button-test/";
            driver.Navigate().GoToUrl(url);

            string[] option = { "1", "3", "5" };
            for (int i = 0; i < option.Length; i++)
            {
                IWebElement radioButton = driver.FindElement(By.CssSelector($"#post-10 > div > form > p:nth-child(6) > input[type=radio]:nth-child({option[i]})"));
                var value = radioButton.GetAttribute("value");
                if (radioButton.GetAttribute("checked") == "true")
                    GreenMessage($"The {option[i]} Radio Button is checked!:{value}");
                else
                    RedMessage($"The {option[i]} Radio Button is NOT checked!:{value}");
                //check the checkbox
                //radioButton.Click();
            }
            Thread.Sleep(3000);
        }

        public static void CheckBox(IWebDriver driver)
        {
            string url = "https://testing.todorvachev.com/check-button-test-3/";
            driver.Navigate().GoToUrl(url);
            string option = "3";//or 1
            IWebElement checkBox = driver.FindElement(By.CssSelector($"#post-33 > div > p:nth-child(8) > input[type=checkbox]:nth-child({option})"));
            var value = checkBox.GetAttribute("value");
            if (checkBox.GetAttribute("checked") == "true")
                GreenMessage($"Check box is checked!:{value}");
            else
                RedMessage($"Check box is NOT checked!:{value}");

            option = "1";
            checkBox = driver.FindElement(By.CssSelector($"#post-33 > div > p:nth-child(8) > input[type=checkbox]:nth-child({option})"));
            value = checkBox.GetAttribute("value");
            if (checkBox.GetAttribute("checked") == "true")
                GreenMessage($"Check box is checked!:{value}");
            else
                RedMessage($"Check box is NOT checked!:{value}");

            //check the checkbox
            checkBox.Click();
            Thread.Sleep(3000);
        }

        public static void SelectorByName(IWebDriver driver)
        {
            driver.Navigate().GoToUrl("https://testing.todorvachev.com/name/");
            IWebElement element = driver.FindElement(By.Name("myName"));
            if (element.Displayed)
            {
                GreenMessage("By Name Element Visible!");
            }
            else
            {
                RedMessage("By Name Something went wrong! Element not visible!");
            }
        }

        public static void SelectorById(IWebDriver driver)
        {
            driver.Navigate().GoToUrl("https://testing.todorvachev.com/id/");
            IWebElement element = driver.FindElement(By.Id("testImage"));
            if (element.Displayed)
            {
                GreenMessage("By Id Element Visible!");
            }
            else
            {
                RedMessage("Something went wrong!By Id Element not visible!");
            }
        }

        public static void SelectorByClassName(IWebDriver driver)
        {
            driver.Navigate().GoToUrl("https://testing.todorvachev.com/class-name/");
            IWebElement element = driver.FindElement(By.ClassName("testClass"));
            if (element.Displayed)
            {
                GreenMessage(element.Text);
            }
            else
            {
                RedMessage("Something went wrong! By ClassName Element not visible!");
            }
        }

        public static void SelectorByCssPath(IWebDriver driver)
        {
            string url = "https://testing.todorvachev.com/css-path/";
            string cssPath = "#post-108 > div > fig  img";
            string xPath = "//*[@id=\"post-108\"]/div/figure/img";
            driver.Navigate().GoToUrl(url);
            //CSS selectors are much better compared to Xpath in Performance,Faster and has better browser support
            try
            {
                var cssPathElement = driver.FindElement(By.CssSelector(cssPath));
                var xPathElement = driver.FindElement(By.XPath(xPath));
                if (cssPathElement.Displayed)
                {
                    GreenMessage("Css Path Element Visible!");
                }
                if (xPathElement.Displayed)
                {
                    GreenMessage("X Path Element Visible!");
                }
            }
            catch (NoSuchElementException e)
            {
                RedMessage(e.Message);
            }

        }

        private static void RedMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void GreenMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
