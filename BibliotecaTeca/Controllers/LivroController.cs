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
            return View();
        }

        public IActionResult Cadastro()
        {
            Livro livro = new Livro("", 0, new DateTime());            
            return View();
        }
     
    }
}
