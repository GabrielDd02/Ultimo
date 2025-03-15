using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using MinhaApp.Servico;

namespace MinhaApp.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        public IAlunoServico _IAlunoServico;

        public AlunoController(IAlunoServico servico)
        {
            _IAlunoServico = servico;
        }

        [HttpPost]
        public IActionResult Adicionar([FromBody] Aluno aluno)
        {

        bool aprovado = _IAlunoServico.AdicionarAluno(aluno.Nome, aluno.Nota);
        return aprovado ? Ok("Aluno aprovado!") : Ok("Aluno reprovado.");
        }
    }
}
