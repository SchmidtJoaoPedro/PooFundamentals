using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoEscola
{
    public class Pessoa
    {
        private string nome;
        private int idade;

        public string Nome { get => nome; set => nome = value; }
        protected int Idade1 { get => idade; }
        public int Idade { set => idade = value; }

        public Pessoa()
        {

        }
    }
}
