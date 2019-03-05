using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Concessionaria.Models
{
    public class Carro
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("nome")]
        public string Nome { get; set; }

        [BsonElement("marca")]
        public string Marca { get; set; }

        [BsonElement("ano")]
        public int Ano { get; set; }

        [BsonElement("peca")]
        public Peca Peca { get; set; }
    }
}
