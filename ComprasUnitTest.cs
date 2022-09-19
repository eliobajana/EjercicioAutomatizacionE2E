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
using EjercicioAutomatizacionE2E.PageObjects;

namespace EjercicioAutomatizacionE2E
{
    public class ComprasUnitTest
    {
        private IWebDriver driver;   

        [SetUp]
        public void Setup()
        {
            var DriverFolder = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @".\Resourses\");
            driver = new ChromeDriver(DriverFolder);

        }

        [TearDown]
        protected void TearDown()
        {
            driver.Quit();
        }

        [Test]
        public void CompraDatosCorrectos()
        {
            MetodosComunes mc = new MetodosComunes(driver);
            HomePage Home = new HomePage(driver);
            CartPage cart = new CartPage(driver);

            try {

                mc.IngresarURL();

                Home.SeleccionarArticulos("Samsung galaxy s6", "Sony vaio i7");

                cart.Comprar();

                cart.IngresarDatos("Elio Bajaña", "Ecuador", "Guayaquil", "4111 1111 1111 1111", "05", "2023");

                cart.ProcesarPago();

                Assert.Pass("Prueba Ejecutada Exitosamente");              
            }
            catch(SystemException ex)
            {
                Assert.Fail("Error en la Ejecucion por: " + ex);

            }

        }

        [Test]
        public void CompraDatosIncorrectos()
        {
            MetodosComunes mc = new MetodosComunes(driver);
            HomePage Home = new HomePage(driver);
            CartPage cart = new CartPage(driver);

            try
            {

                mc.IngresarURL();

                Home.SeleccionarArticulos("Samsung galaxy s6", "Sony vaio i7");

                cart.Comprar();

                cart.IngresarDatos("ZQWQWQW14455", "DS4455", "DS4444", "XXXW33 -.L/* 620..$ $$5%%", "EEEE", "4EFFF/*");

                cart.ProcesarPago();

                Assert.Fail("Realiza la Compra a pesar de Ingresar Datos invalidos");


            }
            catch (SystemException ex)
            {
                Assert.Fail("Error en la Ejecucion por: " + ex);

            }

        }
    }
}