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

        public void SaveLivro(Livro livro)
        {
            dbSet.Add(livro);
            contexto.SaveChanges();
        }
    }
}
