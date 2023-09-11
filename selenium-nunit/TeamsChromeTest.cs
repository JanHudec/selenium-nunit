using NUnit.Framework;
using OpenQA.Selenium;

namespace selenium_nunit
{
    public class TeamsChromeTest : CommonTest
    {
        /// <summary>
        /// Method <c>SendFile</c> sends a file from OneDrive.
        /// </summary>
        [Test]
        public void SendFile()
        {
            Logger.NewSession();
            Logger.LogMessage("Sending file in Chrome started");           

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

            // attach the file
            driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div[2]/div/div/div[2]/div/div[2]/div/div/div/div[1]/button"))
                .Click();

            Thread.Sleep(1000);
            
            driver.SwitchTo().ParentFrame();

            Thread.Sleep(1000);            

            driver.FindElement(By.XPath("/html/body/div[1]/div/div/div/div[7]/div/div/div[3]/div/div[4]/div[1]/div[3]/div/p"))
                .SendKeys(Keys.Enter);

            Thread.Sleep(4000);

            base.TearDown();

            Logger.LogMessage("Sending file in Chrome finished");
        }

        /// <summary>
        /// Method <c>WriteMessage</c> writes a message in chat.
        /// </summary>
        [Test]
        public void WriteMessage()
        {
            Logger.NewSession();
            Logger.LogMessage("Writing a message in Chrome started");

            base.SetUp();
            Thread.Sleep(20000);

            driver.SwitchTo().Frame(driver.FindElement(By.XPath("/html/body/div[6]/div/iframe")));

            Thread.Sleep(1000);

            // write and send the message
            driver.FindElement(By.XPath("/html/body/div[1]/div/div/div/div[7]/div/div/div[3]/div/div[4]/div[1]/div[3]/div/p"))
                .SendKeys("Chrome Test Message" + Keys.Enter);

            Thread.Sleep(3000);

            base.TearDown();

            Logger.LogMessage("Writing a message in Chrome finished");
        }
    }
}
