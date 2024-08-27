using Microsoft.AspNetCore.Mvc;
using PrimeiroMVC.Models;

namespace PrimeiroMVC.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            Aluno a1 = new Aluno(1, "Pedro Henrique", "mxpedro.araujo11@gmail.com", 44448);
            Aluno a2 = new Aluno(2, "Caio Henrique", "Caioxx11@gmail.com", 90725);
            Aluno a3 = new Aluno(3, "francesco bernutti", "Bernutti101@gmail.com", 88790);
            Aluno a4 = new Aluno(4, "Caio Martins ", "martins.speed09@gmail.com", 23754);
            Aluno a5 = new Aluno(5, "Jotaa ferrari", "ferrari.jota21@gmail.com", 57824);

            //Criar uma lista de alunos
            List<Aluno> listAlunos = new List<Aluno>();
            //adcionar os objetos alunos na lista alunos
            listAlunos.Add(a1);
            listAlunos.Add(a2);
            listAlunos.Add(a3);
            listAlunos.Add(a4);
            listAlunos.Add(a5);
            // Enviando a lista de Alunos por pareamento na view 

            return View();
        }
        public IActionResult Cadastrar()
        {
            return View();
        }
    }
}
