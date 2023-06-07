using MariaLunarillos.Auto.Template.SetUp;
using MariaLunarillos.Auto.Template.WebPages.Base;
using OpenQA.Selenium;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using System;
using MariaLunarillos.Auto.Template.Common;
using NUnit.Framework;

namespace MariaLunarillos.WebPages
{
    public class HomePageShop : CommonPage
    {
        public HomePageShop(ISetUpWebDriver setUpWebDriver) : base(setUpWebDriver)
        {
        }
        protected override IWebElement ApartadosBusqueda => throw new System.NotImplementedException();


        
        

        
    }
}
