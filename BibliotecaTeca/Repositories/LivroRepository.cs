using BibliotecaTeca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotecaTeca.Repositories
{
    public class LivroRepository : BaseRepository<Livro>, ILivroRepository
    {
        public LivroRepository(ApplicationContext contexto) : base(contexto)
        {
        }

        public Livro GetLivro(long idLivro)
        {
            return this.dbSet.Find(idLivro);
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
    }
}
