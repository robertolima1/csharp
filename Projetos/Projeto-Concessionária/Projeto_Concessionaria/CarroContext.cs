using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Concessionaria
{
    public class CarroContext
    {
        private IConfiguration configuration;

        public CarroContext(IConfiguration config)
        {
            configuration = config;
        }

        public IMongoDatabase ConnectionBase()
        {
            MongoClient client = new MongoClient(configuration.GetConnectionString("myBase"));
            IMongoDatabase db = client.GetDatabase("mydatabase");
            return db;
        }

    }
}
