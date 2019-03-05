using MongoDB.Driver;
using Projeto_Concessionaria.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Concessionaria
{
    public class CarroService:ICarroService
    {
        private CarroContext _contexto;

        public CarroService(CarroContext context)
        {
            _contexto = context;
        }

        public List<Carro> Get()
        {

            return _contexto
                .ConnectionBase()
                .GetCollection<Carro>("carro")
                .Find<Carro>(book => true)
                .ToList();
        }

        public void Insert(Carro carro)
        {
            try
            {
                _contexto.ConnectionBase().GetCollection<Carro>("carro").InsertOne(carro);
            }
            catch(Exception e)
            {

            }
        }

        public void Remove(string IdCarro)
        {
            try
            {
                _contexto.ConnectionBase().GetCollection<Carro>("carro").DeleteOne(filter => filter.Id == IdCarro);
            }
            catch (Exception e)
            {

            }

        }

        public void Update(Carro carro)
        {
            try
            {
               // _contexto.ConnectionBase().GetCollection<Carro>("carro").FindOneAndUpdate(carro);
            }
            catch
            {

            }
        }
    }
}
