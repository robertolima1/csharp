using BibliotecaTeca.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotecaTeca.Repositories
{
    public class LivroRepository : BaseRepository<Livro>, ILivroRepository
    {
        private readonly IHttpContextAccessor contextAccessor;

        public LivroRepository(ApplicationContext contexto,
            IHttpContextAccessor contextAccessor) : base(contexto)
        {
          this.contextAccessor = contextAccessor;
        }

        public void DropLivro(long id)
        {
            Livro livro = this.dbSet.FirstOrDefault(l => l.Id == id);
            this.dbSet.Remove(livro);
            this.contexto.SaveChanges();
        }

        public Livro GetLivro(long idLivro)
        {
            return this.dbSet
                .FirstOrDefault(l => l.Id == idLivro);
        }

        public List<Livro> ListLivro()
        {
            return this.dbSet.ToList();
        }

        public void SaveLivro(Livro livro)
        {
            this.dbSet.Add(livro);
            this.contexto.SaveChanges();
        }

        public void UpdateLivro(Livro livro)
        {
            this.dbSet.Update(livro);
            this.contexto.SaveChanges();
        }

        //Recupera o código do pedido da sessão
        private int? GetContLivro()
        {
            return contextAccessor.HttpContext.Session.GetInt32("contLivro");
        }

        //Adiciona o código do pedido na sessão
        private void SetContLivro(int livro)
        {
            int cont = this.GetContLivro().HasValue ? this.GetContLivro().Value : 0;
            contextAccessor.HttpContext.Session.SetInt32("contLivro", cont + livro);

        }
    }
}

