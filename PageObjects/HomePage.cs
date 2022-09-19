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

namespace EjercicioAutomatizacionE2E.PageObjects
{
    class HomePage
    {
        private readonly IWebDriver driver;

        public IDictionary<string, object> vars { get; private set; }
        private IJavaScriptExecutor js;

        public HomePage(IWebDriver webDriver)
        {
            this.driver = webDriver;
            js = (IJavaScriptExecutor)driver;
            vars = new Dictionary<string, object>();
        }

        
        public void SeleccionarArticulos(String Articulo1, String articulo2)
        {
            driver.FindElement(By.Id("itemc")).Click();
            Thread.Sleep(1000);

            driver.FindElement(By.LinkText(Articulo1)).Click();
            //driver.FindElement(By.LinkText("Samsung galaxy s6")).Click();

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

            driver.FindElement(By.LinkText(articulo2)).Click();
            //driver.FindElement(By.LinkText("Sony vaio i7")).Click();

            Thread.Sleep(1000);

            driver.FindElement(By.LinkText("Add to cart")).Click();
            Thread.Sleep(1000);

            Assert.That(driver.SwitchTo().Alert().Text, Is.EqualTo("Product added"));
            Thread.Sleep(1000);
            driver.SwitchTo().Alert().Accept();
            Thread.Sleep(1000);

        }
    }
}
