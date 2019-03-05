using Projeto_Concessionaria.Models;
using System.Collections.Generic;

namespace Projeto_Concessionaria
{
    public interface ICarroService
    {
        List<Carro> Get();
        void Insert(Carro carro);
        void Remove(string IdCarro);
        void Update(Carro carro);

    }
}