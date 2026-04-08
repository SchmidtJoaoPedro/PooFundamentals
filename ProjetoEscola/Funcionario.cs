using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoEscola
{
    internal class Funcionario : Pessoa
    {
        private double salarioMensal;

        public double SalarioMensal { get => salarioMensal; set => salarioMensal = value; }

        public string MostrarFuncionario()
        {
            return $"Nome: {Nome} - Idade: {Idade1} - Salário: {SalarioMensal}";
        }   
    }
}
