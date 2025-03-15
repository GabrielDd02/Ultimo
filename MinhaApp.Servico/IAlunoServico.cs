using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinhaApp.Repositorio;
using MinhaApp.Dominio;

namespace MinhaApp.Servico
{
    public interface IAlunoServico
    {
        bool AdicionarAluno(string nome, decimal nota);
    }

    public class AlunoServico : IAlunoServico
    {
        private readonly IAlunoRepositorio _repositorio;
        public AlunoServico(IAlunoRepositorio repositorio)
        {
            _repositorio = repositorio;
        }
        public bool AdicionarAluno(string nome,decimal nota)
        {
            var aluno = new Aluno(nome,nota);
            _repositorio.Salvar(aluno);
            return aluno.EstaAprovado();
        }
    }
}
