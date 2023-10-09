using AutomatizaWebOrange.PageObjects;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace AutomatizaWebOrange.Steps
{
    public class AddEmployeeSteps : Inicializacao
    {
        public static void ValidarFirstNameObrigatorioNaTelaAddEmployee(string Username, string Password, string FirstName, string LastName, string MiddleName)
        {
            LoginSteps.Login(Username, Password);
            WriteLine("Clicar no botão [PIM]");
            Driver.FindElement(DashboardPage.btPIM).Click();
            Thread.Sleep(2000);
            WriteLine("Clicar no botão [+ Add]");
            Driver.FindElement(PIMPage.btAdd).Click();
            Thread.Sleep(1000);
            WriteLine("Não preencher o Primeiro nome");
            Driver.FindElement(AddEmployeePage.FirstName).SendKeys(FirstName);
            Thread.Sleep(1000);
            WriteLine("Preencher o Nome do meio");
            Driver.FindElement(AddEmployeePage.MiddleName).SendKeys(MiddleName);
            Thread.Sleep(1000);
            WriteLine("Preencher o Último nome");
            Driver.FindElement(AddEmployeePage.LastName).SendKeys(LastName);
            Thread.Sleep(2000);
            WriteLine("Clicar no botão [Save]");
            Driver.FindElement(AddEmployeePage.Save).Click();
            WriteLine("Campo obrigatório FirstName validado com sucesso");
            string FirstNameObrigatorio = Convert.ToString(Driver.FindElement(LoginPage.CampoObrigatorio).Text);
            Assert.AreEqual("Required", FirstNameObrigatorio, "Campo obrigatório FirstName validado com sucesso");
        }
        public static void ValidarLastNameObrigatorioNaTelaAddEmployee(string Username, string Password, string FirstName, string MiddleName, string LastName)
        {
            LoginSteps.Login(Username, Password);
            WriteLine("Clicar no botão [PIM]");
            Driver.FindElement(DashboardPage.btPIM).Click();
            Thread.Sleep(2000);
            WriteLine("Clicar no botão [+ Add]");
            Driver.FindElement(PIMPage.btAdd).Click();
            Thread.Sleep(1000);
            WriteLine("Preencher o Primeiro nome");
            Driver.FindElement(AddEmployeePage.FirstName).SendKeys(FirstName);
            Thread.Sleep(1000);
            WriteLine("Preencher o Nome do meio");
            Driver.FindElement(AddEmployeePage.MiddleName).SendKeys(MiddleName);
            Thread.Sleep(1000);
            WriteLine("Não preencher o Último nome");
            Driver.FindElement(AddEmployeePage.LastName).SendKeys(LastName);
            Thread.Sleep(2000);
            WriteLine("Clicar no botão [Save]");
            Driver.FindElement(AddEmployeePage.Save).Click();
            WriteLine("Campo obrigatório LastName validado com sucesso");
            string LastNameObrigatorio = Convert.ToString(Driver.FindElement(LoginPage.CampoObrigatorio).Text);
            Assert.AreEqual("Required", LastNameObrigatorio, "Campo obrigatório LastName validado com sucesso");
        }
    }
}
