using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinhaApp.Dominio;

namespace MinhaApp.Repositorio
{
    public interface IAlunoRepositorio
    {
        void Salvar(Aluno aluno);
    }
    public class AlunoRepositorio : IAlunoRepositorio
    {
        private readonly List<Aluno> _alunos = new();

        public void Salvar(Aluno aluno)
        {
            _alunos.Add(aluno);
        }
    }
}
