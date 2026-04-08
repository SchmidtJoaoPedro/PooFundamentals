using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ProjetoEscola
{
    internal class Professor : Pessoa
    {
        public string titulacao;

        public string Titulacao { get => titulacao; set => titulacao = value; }

        public string MostrarProfessor()
        {
            return $"Nome: {Nome} - Idade: {Idade1} - Titulação: {Titulacao}";
        }
    }
}
