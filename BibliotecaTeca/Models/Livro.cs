using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace BibliotecaTeca.Models
{
    [DataContract]
    public class Livro : BaseModel
    {
        public Livro(string nome, decimal preco, DateTime dataPostagem)
        {
         
            Nome = nome;
            Preco = preco;
            DataPostagem = dataPostagem;
        }

        [Required]
        public string Nome { get; set; }

        [Required]
        public Decimal Preco { get; set; }

        [Required]
        public DateTime DataPostagem { get; set; }

        [Required]
        public Pedido Pedido { get; set; }
    }
}
