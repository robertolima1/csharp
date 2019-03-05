using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Concessionaria.Models
{
    public class Peca
    {    
        [BsonElement("nome")]
        public string Nome { get; set; }
       
        [BsonElement("quantidade")]
        public int Quantidade { get; set; }        
    }
}
