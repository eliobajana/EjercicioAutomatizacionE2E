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
    class CartPage
    {
        private readonly IWebDriver driver;

        public IDictionary<string, object> vars { get; private set; }
        private IJavaScriptExecutor js;

        public CartPage(IWebDriver webDriver)
        {
            this.driver = webDriver;
            js = (IJavaScriptExecutor)driver;
            vars = new Dictionary<string, object>();
        }

        public void Comprar()
        {
            driver.FindElement(By.Id("cartur")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.CssSelector(".btn-success")).Click();
            Thread.Sleep(1000);
        }

        public void IngresarDatos(String name, String country,String city,String card, String month, String year)
        {
            driver.FindElement(By.Id("name")).Click();

            driver.FindElement(By.Id("name")).SendKeys(name);

            driver.FindElement(By.Id("country")).Click();

            driver.FindElement(By.Id("country")).SendKeys(country);

            driver.FindElement(By.Id("city")).Click();

            driver.FindElement(By.Id("city")).SendKeys(city);

            driver.FindElement(By.Id("card")).Click();

            driver.FindElement(By.Id("card")).SendKeys(card);

            driver.FindElement(By.Id("month")).Click();

            driver.FindElement(By.Id("month")).SendKeys(month);

            driver.FindElement(By.Id("year")).Click();

            driver.FindElement(By.Id("year")).SendKeys(year);
            Thread.Sleep(1000);

        }

        public void ProcesarPago()
        {
            driver.FindElement(By.CssSelector("#orderModal .btn-primary")).Click();
            Thread.Sleep(1000);

            driver.FindElement(By.CssSelector(".confirm")).Click();
            Thread.Sleep(1000);

        }


    }
}
