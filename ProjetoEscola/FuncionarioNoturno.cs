using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoEscola
{
    internal class FuncionarioNoturno : Funcionario
    {
        private double adicionalNoturno;

        public double AdicionalNoturno { get => adicionalNoturno; set => adicionalNoturno = value; }

        public string MostrarFuncionarioNoturno()
        {
            return $"{MostrarFuncionario() + MostrarFuncionarioNoturno().ToString()}";
        }
    }
}
