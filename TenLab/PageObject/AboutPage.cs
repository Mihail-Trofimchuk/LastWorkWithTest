using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenLab.PageObject
{
    public class AboutPage
    {
        private IWebDriver _webDriver;

        private readonly By _certainQuestion = By.XPath("/html/body/div[3]/div[34]/div[6]/div[12]/h2");

        public AboutPage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }
    }
}
