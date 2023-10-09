using AutomatizaWebOrange.Steps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace AutomatizaWebOrange.Feature
{
    [TestClass]
    public class PIM : Inicializacao
    {
        [TestMethod]
        [TestCategory("08")]
        public void ValidarTelaEmployeeList()
        {
            WriteLine("Dado que: Acesse o site 'https://opensource-demo.orangehrmlive.com/web/index.php/auth/login'");
            WriteLine("E: Preencher os campos @UserName e @Password com usuário previamente cadastrado");
            WriteLine("E: Clicar no botão[Login]");
            WriteLine("E: O login ser realizado com sucesso.");
            WriteLine("E: Exibir a tela Dashboard");
            WriteLine("E: Clicar no botão[PIM]");
            WriteLine("E: Exibir a tela 'PIM'");
            WriteLine("Quando: Clicar no botão [+ Add]");
            WriteLine("Então: Será redirecionado ao link: 'https://opensource-demo.orangehrmlive.com/web/index.php/pim/addEmployee'");


            PIMSteps.ValidarTelaEmployeeList("Admin", "admin123");
        }

        [TestMethod]
        [TestCategory("09")]
        public void ValidarTelaReports()
        {
            WriteLine("Dado que: Acesse o site 'https://opensource-demo.orangehrmlive.com/web/index.php/auth/login'");
            WriteLine("E: Preencher os campos @UserName e @Password com usuário previamente cadastrado");
            WriteLine("E: Clicar no botão[Login]");
            WriteLine("E: O login ser realizado com sucesso.");
            WriteLine("E: Exibir a tela Dashboard");
            WriteLine("E: Clicar no botão[PIM]");
            WriteLine("E: Exibir a tela 'PIM'");
            WriteLine("E: Clicar no botão [Reports]");
            WriteLine("Quando: Clicar no botão [+ Add]");
            WriteLine("Então: Será redirecionado ao link: 'https://opensource-demo.orangehrmlive.com/web/index.php/pim/definePredefinedReport'");


            PIMSteps.ValidarTelaReports("Admin", "admin123");

        }
    }
}
