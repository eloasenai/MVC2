using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            Aluno a1 = new Aluno(1, "Cristiano de Paula", "cristiano.paula@sp.senai.br", 123456);
            Aluno a2 = new Aluno(2, "Paula cristina", "cristina.paula@sp.senai.br", 654321);
            Aluno a3 = new Aluno(3, "Maria Josefina", "maria.josefina@sp.senai.br", 678910);
            Aluno a4 = new Aluno(4, "José Ricardo", "jose.ricardo@sp.senai.br", 135791);
            Aluno a5 = new Aluno(5, "Miguel Antonio", "miguel.antonio@sp.senai.br", 246810);

            //CRIAR UMA LISTA DE ALUNOS
            List<Aluno> ListaAlunos = new List<Aluno>();
            //ADICIONAR OS OBJETOS ALUNOS NA LISTA ALUNOS
            ListaAlunos.Add(a1);
            ListaAlunos.Add(a2);
            ListaAlunos.Add(a3);
            ListaAlunos.Add(a4);
            ListaAlunos.Add(a5);
            //ENVIANDO A LISTA DE ALUNOS POR PARAMETRO NA VIEW INDEX
            return View(ListaAlunos);
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

    }
}
