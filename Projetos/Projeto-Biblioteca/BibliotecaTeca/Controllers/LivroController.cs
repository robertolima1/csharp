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
        public IActionResult EditarItem(Livro livro)
        {
            this.livroRepository.UpdateLivro(livro);
            return RedirectToAction("Index");
        }
        
        public IActionResult Alugar(long id)
        {
            this.livroRepository.SetListPedido(id);
            return RedirectToAction("Index");
        }

        public IActionResult Editar(long id)
        {
            Livro livro = this.livroRepository.GetLivro(id);
            return View(livro);
        }

        public IActionResult Excluir(long id)
        {
            this.livroRepository.DropLivro(id);
            return RedirectToAction("Index");
        }

        public IActionResult Carrinho()
        {   
            return View(this.livroRepository.ListLivroInCarrinho());
        }
    }
}
