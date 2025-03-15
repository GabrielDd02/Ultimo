using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaApp.Dominio
{
    public class Aluno
    {
        public string Nome { get; private set; }
        public decimal Nota { get; private set; }

        public Aluno(string nome, decimal nota)
    { 
        Nome = nome;
        Nota = nota;
    }
    public bool EstaAprovado()
        {
            return Nota >= 7.0m;
        }
    }
}
