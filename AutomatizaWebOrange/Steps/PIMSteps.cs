using AutomatizaWebOrange.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace AutomatizaWebOrange.Steps
{
    public class PIMSteps : Inicializacao
    {
        public static void ValidarTelaEmployeeList(string Username, string Password)
        {
            LoginSteps.Login(Username, Password);
            WriteLine("Clicar no botão [PIM]");
            Driver.FindElement(DashboardPage.btPIM).Click();
            Thread.Sleep(2000);
            WriteLine("Clicar no botão [+ Add]");
            Driver.FindElement(PIMPage.btAdd).Click();
            WriteLine("Validar se está na tela Add Employee");
            string pgAddEmployeeAtual = Convert.ToString(Driver.Url);
            string pgAddEmployeeEsperado = Convert.ToString("https://opensource-demo.orangehrmlive.com/web/index.php/pim/addEmployee");
            Assert.AreEqual(pgAddEmployeeEsperado, pgAddEmployeeAtual, "Página carregada com sucesso!");
        }
        public static void ValidarTelaReports(string Username, string Password)
        {
            LoginSteps.Login(Username, Password);
            WriteLine("Clicar no botão [PIM]");
            Driver.FindElement(DashboardPage.btPIM).Click();
            Thread.Sleep(2000);
            WriteLine("Clicar no botão [Reports]");
            Driver.FindElement(PIMPage.btReports).Click();
            Thread.Sleep(2000);
            WriteLine("Validar se está na tela Reports");
            string pgReportsAtual = Convert.ToString(Driver.Url);
            string pgReportsEsperado = Convert.ToString("https://opensource-demo.orangehrmlive.com/web/index.php/pim/viewDefinedPredefinedReports");
            Assert.AreEqual(pgReportsEsperado, pgReportsAtual, "Página carregada com sucesso!");
        }        
    }
}
