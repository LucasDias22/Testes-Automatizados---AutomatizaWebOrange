using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatizaWebOrange.PageObjects
{
    internal class PIMPage
    {
        public static By pgRecruitmet = By.XPath("//*[@class='oxd-text oxd-text--h6 oxd-topbar-header-breadcrumb-module']");
        public static By btAdd = By.XPath("//*[@class='oxd-button oxd-button--medium oxd-button--secondary']");
        public static By btReports = By.XPath("//*[@id=\"app\"]/div[1]/div[1]/header/div[2]/nav/ul/li[4]");
    }
}
