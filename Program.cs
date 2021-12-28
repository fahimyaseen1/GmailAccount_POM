using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GmailLogin
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();


            Console.WriteLine("Hello Gmail");
            //driver.Navigate().GoToUrl("http://www.gmail.com");
            driver.Navigate().GoToUrl("https://accounts.google.com/signin/chrome/sync/identifier?ssp=1&continue=https%3A%2F%2Fwww.google.com%2F&flowName=GlifDesktopChromeSync");

            System.Threading.Thread.Sleep(1000);
            //driver.FindElement(By.ClassName("daaWTb")).Click();
            //System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.Name("identifier")).SendKeys("fahimyaseen752");
            System.Threading.Thread.Sleep(1000);

            driver.FindElement(By.ClassName("VfPpkd-vQzf8d")).Click();
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.Name("password")).SendKeys("**********");
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.ClassName("VfPpkd-vQzf8d")).Click();

            // Open Gmail Account Successfull

            // Selected Email for Delete
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.ClassName("oZ-jc T-Jo J-J5-Ji T-Jo-Jp")).Click();

            // Clicked on Delete Button for selected email 
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.ClassName("ar9 T-I-J3 J-J5-Ji")).Click();

        }
    }
}
