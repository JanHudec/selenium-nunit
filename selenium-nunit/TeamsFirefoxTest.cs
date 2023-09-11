using NUnit.Framework;
using OpenQA.Selenium;

namespace selenium_nunit
{
    public class TeamsFirefoxTest : CommonTest
    {
        /// <summary>
        /// Method <c>SendFiles</c> sends two files from OneDrive.
        /// </summary>
        [Test]
        public void SendFiles()
        {
            Logger.NewSession();
            Logger.LogMessage("Sending files in Firefox started");

            base.SetUp();
            Thread.Sleep(20000);

            driver.SwitchTo().Frame(driver.FindElement(By.XPath("/html/body/div[6]/div/iframe")));

            // click on attach file
            driver.FindElement(By.XPath("//*[@id=\"message-pane-layout-a11y\"]/div[3]/div/div[4]/div[2]/div[1]/div[1]/button[2]"))
                .Click();

            // onedrive
            driver.FindElement(By.XPath("/html/body/div[6]/div/div[2]/ul/li[1]"))
                .Click();

            Thread.Sleep(5000);

            driver.SwitchTo().Frame(driver.FindElement(By.XPath("/html/body/div[6]/div/div[2]/div/div/div/iframe")));

            // select first file
            driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div[2]/div/div[2]/main/div/div/div/div/div/div/div/div/div/div[2]/div/div/div/div[1]"))
                .Click();

            Thread.Sleep(1000);

            // select second file
            driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/div[2]/main/div/div/div/div/div/div/div/div/div/div[2]/div/div/div/div[2]/div/div/div[1]"))
                .Click();
                        
            // attach the file
            driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div[2]/div/div/div[2]/div/div[2]/div/div/div/div[1]/button"))
                .Click();

            Thread.Sleep(1000);

            driver.SwitchTo().ParentFrame();

            Thread.Sleep(1000);

            driver.FindElement(By.XPath("/html/body/div[1]/div/div/div/div[7]/div/div/div[3]/div/div[4]/div[1]/div[3]/div"))
                .SendKeys(Keys.Enter);

            Thread.Sleep(4000);

            base.TearDown();

            Logger.LogMessage("Sending files in Firefox finished");
        }

        /// <summary>
        /// Method <c>WriteMessages</c> writes three messages in chat.
        /// </summary>
        [Test]
        public void WriteMessages()
        {
            Logger.NewSession();
            Logger.LogMessage("Writing messages in Firefox started");

            base.SetUp();
            Thread.Sleep(20000);

            driver.SwitchTo().Frame(driver.FindElement(By.XPath("/html/body/div[6]/div/iframe")));
            
            Thread.Sleep(1000);

            // write and send the messages
            driver.FindElement(By.XPath("/html/body/div[1]/div/div/div/div[7]/div/div/div[3]/div/div[4]/div[1]/div[3]/div"))
                .SendKeys("First Firefox Test Message" + Keys.Enter);

            Thread.Sleep(1000);

            driver.FindElement(By.XPath("/html/body/div[1]/div/div/div/div[7]/div/div/div[3]/div/div[4]/div[1]/div[3]/div"))
                .SendKeys("Second Firefox Test Message" + Keys.Enter);

            Thread.Sleep(1000);

            driver.FindElement(By.XPath("/html/body/div[1]/div/div/div/div[7]/div/div/div[3]/div/div[4]/div[1]/div[3]/div"))
                .SendKeys("Third Firefox Test Message" + Keys.Enter);

            Thread.Sleep(3000);

            base.TearDown();

            Logger.LogMessage("Writing messages in Firefox finished");
        }
    }
}
