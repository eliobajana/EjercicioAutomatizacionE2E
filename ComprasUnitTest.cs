using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;

namespace EjercicioAutomatizacionE2E
{
    public class ComprasUnitTest
    {
        private IWebDriver driver;

        public IDictionary<string, object> vars { get; private set; }
        private IJavaScriptExecutor js;
       // private Alert alert = driver.LinkText("Add to cart").alert();

        [SetUp]
        public void Setup()
        {
            var DriverFolder = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @".\Resourses\");
            Console.WriteLine(DriverFolder);

            driver = new ChromeDriver(DriverFolder);

            js = (IJavaScriptExecutor)driver;
            vars = new Dictionary<string, object>();
            //Alert alert = driver.switchTo().alert();
        }

        [TearDown]
        protected void TearDown()
        {
            driver.Quit();
        }

        [Test]
        public void CompraDatosCorrectos()
        {

            driver.Navigate().GoToUrl("https://www.demoblaze.com/");
            driver.Manage().Window.Maximize();
            Thread.Sleep(1000);

            driver.FindElement(By.Id("itemc")).Click();
            Thread.Sleep(1000);

            driver.FindElement(By.LinkText("Samsung galaxy s6")).Click();
            Thread.Sleep(1000);

            driver.FindElement(By.LinkText("Add to cart")).Click();
            Thread.Sleep(1000);

            Assert.That(driver.SwitchTo().Alert().Text, Is.EqualTo("Product added"));
            Thread.Sleep(1000);
            driver.SwitchTo().Alert().Accept();

            Thread.Sleep(1000);
            driver.FindElement(By.CssSelector(".active > .nav-link")).Click();
            Thread.Sleep(1000);

            driver.FindElement(By.LinkText("Laptops")).Click();
            Thread.Sleep(1000);

            driver.FindElement(By.LinkText("Sony vaio i7")).Click();
            Thread.Sleep(1000);

            driver.FindElement(By.LinkText("Add to cart")).Click();
            Thread.Sleep(1000);

            Assert.That(driver.SwitchTo().Alert().Text, Is.EqualTo("Product added"));
            Thread.Sleep(1000);
            driver.SwitchTo().Alert().Accept();


            Thread.Sleep(1000);
            driver.FindElement(By.Id("cartur")).Click();
            Thread.Sleep(1000);

            driver.FindElement(By.CssSelector(".btn-success")).Click();
            Thread.Sleep(1000);

            driver.FindElement(By.Id("name")).Click();
            Thread.Sleep(1000);

            driver.FindElement(By.Id("name")).SendKeys("Elio Bajaña");
            Thread.Sleep(1000);

            driver.FindElement(By.Id("country")).Click();

            driver.FindElement(By.Id("country")).SendKeys("Ecuador");

            driver.FindElement(By.Id("city")).Click();

            driver.FindElement(By.Id("city")).SendKeys("Guayaquil");

            driver.FindElement(By.Id("card")).Click();

            driver.FindElement(By.Id("card")).SendKeys("4000000011111111");

            driver.FindElement(By.Id("month")).Click();

            driver.FindElement(By.Id("month")).SendKeys("05");

            driver.FindElement(By.Id("year")).Click();

            driver.FindElement(By.Id("year")).SendKeys("2025");
            Thread.Sleep(1000);

            driver.FindElement(By.CssSelector("#orderModal .btn-primary")).Click();
            Thread.Sleep(1000);

            driver.FindElement(By.CssSelector(".confirm")).Click();
        }

        [Test]
        public void CompraDatosIncorrectos()
        {
            driver.Navigate().GoToUrl("https://www.demoblaze.com/");
            driver.Manage().Window.Maximize();
            Thread.Sleep(1000);

            driver.FindElement(By.Id("itemc")).Click();
            Thread.Sleep(1000);

            driver.FindElement(By.LinkText("Samsung galaxy s6")).Click();
            Thread.Sleep(1000);

            driver.FindElement(By.LinkText("Add to cart")).Click();
            Thread.Sleep(1000);

            Assert.That(driver.SwitchTo().Alert().Text, Is.EqualTo("Product added"));
            Thread.Sleep(1000);
            driver.SwitchTo().Alert().Accept();

            Thread.Sleep(1000);
            driver.FindElement(By.CssSelector(".active > .nav-link")).Click();
            Thread.Sleep(1000);

            driver.FindElement(By.LinkText("Laptops")).Click();
            Thread.Sleep(1000);

            driver.FindElement(By.LinkText("Sony vaio i7")).Click();
            Thread.Sleep(1000);

            driver.FindElement(By.LinkText("Add to cart")).Click();
            Thread.Sleep(1000);

            Assert.That(driver.SwitchTo().Alert().Text, Is.EqualTo("Product added"));
            Thread.Sleep(1000);
            driver.SwitchTo().Alert().Accept();


            Thread.Sleep(1000);
            driver.FindElement(By.Id("cartur")).Click();
            Thread.Sleep(1000);

            driver.FindElement(By.CssSelector(".btn-success")).Click();
            Thread.Sleep(1000);

            driver.FindElement(By.Id("name")).Click();
            Thread.Sleep(1000);

            driver.FindElement(By.Id("name")).SendKeys("sadsadsds asdsa");
            Thread.Sleep(1000);

            driver.FindElement(By.Id("country")).Click();

            driver.FindElement(By.Id("country")).SendKeys("sadsadewdrw");

            driver.FindElement(By.Id("city")).Click();

            driver.FindElement(By.Id("city")).SendKeys("erewtre");

            driver.FindElement(By.Id("card")).Click();

            driver.FindElement(By.Id("card")).SendKeys("tretretrtr");

            driver.FindElement(By.Id("month")).Click();

            driver.FindElement(By.Id("month")).SendKeys("rtrtrt");

            driver.FindElement(By.Id("year")).Click();

            driver.FindElement(By.Id("year")).SendKeys("rttrtrt");
            Thread.Sleep(1000);

            driver.FindElement(By.CssSelector("#orderModal .btn-primary")).Click();
            Thread.Sleep(1000);

            driver.FindElement(By.CssSelector(".confirm")).Click();

            Assert.Fail("Permite Ingresar Datos invalidos");
        }
    }
}