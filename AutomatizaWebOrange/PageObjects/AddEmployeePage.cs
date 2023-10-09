using AutomatizaWebOrange.Steps;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AutomatizaWebOrange.PageObjects
{
    public class AddEmployeePage
    {
        public static By FirstName = By.XPath("//*[@name='firstName']");
        public static By LastName = By.XPath("//*[@name='lastName']");
        public static By MiddleName = By.XPath("//*[@name='middleName']");
        public static By Save = By.XPath("//*[@type='submit']");
        public static By Cancel = By.XPath("//*[@class='oxd-button oxd-button--medium oxd-button--ghost']");
        public static By CampoObrigatorio = By.XPath("//*[(text()='Required')]");






    }
}
