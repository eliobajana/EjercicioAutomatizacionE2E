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
     class MetodosComunes
    {
        private readonly IWebDriver driver;

        public IDictionary<string, object> vars { get; private set; }
        private IJavaScriptExecutor js;

        public MetodosComunes(IWebDriver webDriver)
        {
            this.driver = webDriver;
            js = (IJavaScriptExecutor)driver;
            vars = new Dictionary<string, object>();
        }


        public void IngresarURL()
        {
            driver.Navigate().GoToUrl("https://www.demoblaze.com/");
            driver.Manage().Window.Maximize();
            Thread.Sleep(1000);

        }
    }
}
