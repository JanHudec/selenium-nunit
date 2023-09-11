using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Console.WriteLine("Send file in Chrome is running");
            Logger.LogMessage("Sending file in Chrome started");           

            base.SetUp();
            Thread.Sleep(20000);

            driver.SwitchTo().Frame(driver.FindElement(By.XPath("/html/body/div[6]/div/iframe")));
            // driver.SwitchTo().Frame(driver.FindElement(By.XPath("/html/body/div[5]/div/iframe")));

            // click on attach file
            driver.FindElement(By.XPath("//*[@id=\"message-pane-layout-a11y\"]/div[3]/div/div[4]/div[2]/div[1]/div[1]/button[2]"))
                .Click();

            // onedrive
            driver.FindElement(By.XPath("/html/body/div[6]/div/div[2]/ul/li[1]"))
                .Click();
            // #main-window-body > div.r1ugpin8.___ssrymk0.f8497fr.f3rmtva.f19n0e5.f1o700av.fui-FluentProvider1 > div > div.ui-popup__content__content.jw.eo.gl.ayo.axs.axt.axu.axv.et.eu.ev.ew.kv.kw.kx.ky.gn.dg.ks.di.kt.ayp > ul > li:nth-child(1)
            // /html/body/div[6]/div/div[2]/ul/li[1]

            Thread.Sleep(5000);

            driver.SwitchTo().Frame(driver.FindElement(By.XPath("/html/body/div[6]/div/div[2]/div/div/div/iframe")));

            // /html/body/div[1]/div/div[1]/div[2]/div/div[2]/main/div/div/div/div/div/div/div/div/div/div[2]/div/div/div/div[1]/div/div/div[1]
            // //*[@id="appRoot"]/div/div[1]/div[2]/div/div[2]/main/div/div/div/div/div/div/div/div/div/div[2]/div/div/div/div[1]/div/div/div[1]
            // #appRoot > div > div.root_051b5aae.od-FilePicker > div.root_f67c6556.absolute_f67c6556 > div > div.main_051b5aae.od-FilePicker-main.noSearch_051b5aae > main > div > div > div > div > div > div > div > div > div > div.ms-DetailsList-contentWrapper.contentWrapper_dc41814b > div > div > div > div:nth-child(1) > div > div > div.checkCell_0494fb48
            // /html/body/div[1]/div/div[1]/div[2]/div/div[2]/main/div/div/div/div/div/div/div/div/div/div[2]/div/div/div/div[1]


            // my files
            driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div[2]/div/div/main/div/div/div/div/div/div[2]/div/div/div/div/nav/div[1]/div/ul/li[1]"))
                .Click();




            Thread.Sleep(2000);



            // base.TearDown();            
        }

        /// <summary>
        /// Method <c>WriteMessage</c> writes a message in chat.
        /// </summary>
        [Test]
        public void WriteMessage()
        {
            Logger.LogMessage("Writing a message in Chrome started");

            base.SetUp();
            Thread.Sleep(20000);

            driver.SwitchTo().Frame(driver.FindElement(By.XPath("/html/body/div[6]/div/iframe")));

            Thread.Sleep(1000);

            // write and send the message
            driver.FindElement(By.XPath("/html/body/div[1]/div/div/div/div[7]/div/div/div[3]/div/div[4]/div[1]/div[3]/div/p"))
                .SendKeys("Chrome Test Message" + Keys.Enter);

            Thread.Sleep(10000);

            base.TearDown();            
        }
    }
}
