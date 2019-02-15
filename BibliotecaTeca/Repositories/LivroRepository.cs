using BibliotecaTeca.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
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
        public int? GetContLivro()
        {
            return contextAccessor.HttpContext.Session.GetInt32("contLivro");
        }

        //Adiciona o código do pedido na sessão
        public void SetContLivro(long idLivro)
        {
            int cont = this.GetContLivro().HasValue ? this.GetContLivro().Value : 0;
            contextAccessor.HttpContext.Session.SetInt32("contLivro", cont + 1);            

        }

        public List<string> GetListPedido()
        {
            string pedidos =  contextAccessor.HttpContext.Session.GetString("Pedidos");
            List<string> pedidosJson = null;
            if (pedidos != null)
            {
                pedidosJson = JsonConvert.DeserializeObject<List<string>>(pedidos);                
            }
            return pedidosJson;
        }

        public void SetListPedido(long idLivro)
        {
            List<string> pedidos = this.GetListPedido();
            if (pedidos != null)
            {
                pedidos.Add(idLivro.ToString());
                string json = JsonConvert.SerializeObject(pedidos);
                contextAccessor.HttpContext.Session.SetString("Pedidos", json);

            }
            else
            {
                List<string> pedidosNovos = new List<string>();
                pedidosNovos.Add(idLivro.ToString());
                string json = JsonConvert.SerializeObject(pedidosNovos);
                contextAccessor.HttpContext.Session.SetString("Pedidos", json);
            }   
        }
    }
}

