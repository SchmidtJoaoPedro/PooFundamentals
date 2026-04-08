using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ProjetoEscola
{
    internal class Aluno : Pessoa
    {
        private string matricula;

        public string Matricula { get => matricula; set => matricula = value; }

        public Aluno()
        { }
        public string MostrarAluno()
        {
            return $"Nome: {Nome} - Idade: {Idade1} - Matricula: {Matricula}";
        }
    }
}