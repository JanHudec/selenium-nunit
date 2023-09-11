using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;

namespace selenium_nunit
{
    public class CommonTest
    {
        protected IWebDriver driver;

        /// <summary>
        /// Method <c>SetUp</c> logs a test that is just starting and initialize the WebDriver.
        /// </summary>
        [SetUp]
        public void SetUp()
        {            
            Logger.LogMessage("Loging started");
            driver = GetWebDriver();            

            driver.Url = "https://teams.microsoft.com/";            

            Thread.Sleep(3000);

            // enter email address
            driver.FindElement(By.XPath("/html/body/div/form[1]/div/div/div[2]/div[1]/div/div/div/div/div[1]/div[3]/div/div/div/div[2]/div[2]/div/input[1]"))
                .SendKeys(LoginCredentials.GetLogin() + Keys.Enter);

            Thread.Sleep(3000);

            // enter password
            driver.FindElement(By.XPath("/html/body/div/form[1]/div/div/div[2]/div[1]/div/div/div/div/div/div[3]/div/div[2]/div/div[3]/div/div[2]/input"))
                .SendKeys(LoginCredentials.GetPassword() + Keys.Enter);

            Thread.Sleep(1000);

            // cancel stay logged in prompt
            driver.FindElement(By.XPath("/html/body/div/form/div/div/div[2]/div[1]/div/div/div/div/div/div[3]/div/div[2]/div/div[3]/div[2]/div/div/div[1]/input"))
                .Click();

            Thread.Sleep(30000);

            // go to Automation chat
            driver.FindElement(By.CssSelector("#app-bar-86fcd49b-61a2-4701-b771-54728cd291fb"))
                .Click();

            Logger.LogMessage("Loging finished");
        }

        /// <summary>
        /// Method <c>TearDown</c> logs a test result and closes the WebDriver.
        /// </summary>
        [TearDown]
        public void TearDown()
        {            
            Logger.LogMessage("Test result: success");  // todo
            driver.Close();
        }


        private IWebDriver GetWebDriver()
        {
            if (this.GetType() == typeof(TeamsChromeTest))
            {
                return new ChromeDriver();
            }
            else if (this.GetType() == typeof(TeamsFirefoxTest))
            {
                FirefoxOptions options = new FirefoxOptions();

                // Set the Firefox profile to allow third-party cookies
                FirefoxProfile profile = new FirefoxProfile();
                profile.SetPreference("network.cookie.cookieBehavior", 0); // 0 = Accept all cookies
                profile.SetPreference("network.cookie.lifetimePolicy", 2); // 2 = Accept third-party cookies

                options.Profile = profile;
                return new FirefoxDriver(options);
            }
            else
            {
                throw new NotImplementedException("Unsupported WebDriver type for the child class.");
            }
        }
    }
}
