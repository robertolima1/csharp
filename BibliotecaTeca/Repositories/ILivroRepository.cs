using BibliotecaTeca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotecaTeca.Repositories
{
    public interface ILivroRepository
    {
        void SaveLivro(Livro livro);
        List<Livro> ListLivro();
    }
}
