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
    public class AddEmployee : Inicializacao
    {
        [TestMethod]
        [TestCategory("10")]
        public void ValidarFirstNameObrigatorioNaTelaAddEmployee()
        {
            WriteLine("Dado que: Acesse o site 'https://opensource-demo.orangehrmlive.com/web/index.php/auth/login'");
            WriteLine("E: Preencher os campos @UserName e @Password com usuário previamente cadastrado");
            WriteLine("E: clicar no botão[Login]");
            WriteLine("E: O login ser realizado com sucesso.");
            WriteLine("E: Exibir a tela Dashboard");
            WriteLine("E: Clicar no botão[PIM]");
            WriteLine("E: Exibir a tela 'PIM'");
            WriteLine("E: Clicar no botão [+ Add]");
            WriteLine("E: Exibir a tela Add Employee");
            WriteLine("E: Não preencher o campo @FirstName ");
            WriteLine("E: Preencher os campos @Middle Name e @LastName com os dados do candidato");
            WriteLine("Quando clicar no botão [Save]");
            WriteLine("Então: O cadastro não será permitido");
            WriteLine("E: Será exibido a mensagem 'Required' logo abaixo no campo @FirstName");
            AddEmployeeSteps.ValidarFirstNameObrigatorioNaTelaAddEmployee("Admin", "admin123", "", "Ferreira", "Dias");

        }

        [TestMethod]
        [TestCategory("11")]
        public void ValidarLastNameObrigatorioNaTelaAddEmployee()
        {
            WriteLine("Dado que: Acesse o site 'https://opensource-demo.orangehrmlive.com/web/index.php/auth/login'");
            WriteLine("E: Preencher os campos @UserName e @Password com usuário previamente cadastrado");
            WriteLine("E: clicar no botão[Login]");
            WriteLine("E: O login ser realizado com sucesso.");
            WriteLine("E: Exibir a tela Dashboard");
            WriteLine("E: Clicar no botão[PIM]");
            WriteLine("E: Exibir a tela 'PIM'");
            WriteLine("E: Clicar no botão [+ Add]");
            WriteLine("E: Exibir a tela Add Employee");
            WriteLine("E: Não preencher o campo @Last Name ");
            WriteLine("E: Preencher os campos @First Name e @Middle Name com os dados do candidato");
            WriteLine("Quando clicar no botão [Save]");
            WriteLine("Então: O cadastro não será permitido");
            WriteLine("E: Será exibido a mensagem 'Required' logo abaixo no campo @Last Name");
            AddEmployeeSteps.ValidarLastNameObrigatorioNaTelaAddEmployee("Admin", "admin123", "Lucas", "Ferreira", "");

        }
    }
}
