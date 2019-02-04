using BibliotecaTeca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotecaTeca.Repositories
{
    public class LivroRepository : BaseRepository<Livro>
    {
        public LivroRepository(ApplicationContext contexto) : base(contexto)
        {
        }
    }
}
