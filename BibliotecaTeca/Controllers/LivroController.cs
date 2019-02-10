using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BibliotecaTeca.Models;
using BibliotecaTeca.Repositories;
using Microsoft.AspNetCore.Mvc;


namespace BibliotecaTeca.Controllers
{

    public class LivroController : Controller
    {
        private readonly ILivroRepository livroRepository;

        public LivroController(ILivroRepository livroRepository)
        {
            this.livroRepository = livroRepository;
        }

        public IActionResult Index()
        {
            

            return View(this.livroRepository.ListLivro());
        }

        public IActionResult Cadastro()
        {
            Livro livro = new Livro("", 0, new DateTime(), 0);            
            return View();
        }

        [HttpPost]
        public IActionResult CadastroItem(Livro livro)
        {
            this.livroRepository.SaveLivro(livro);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Alugar(long idLivro)
        {                   
            return RedirectToAction("Index");
        }

        public IActionResult Editar(long idLivro)
        {
            Livro livro = this.livroRepository.GetLivro(idLivro);
            return View(livro);
        }

        public IActionResult Excluir(long idLivro)
        {
            return View();
        }

        public IActionResult Carrinho()
        {
            return View();
        }
    }
}
