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
        public Livro(string nome, decimal preco, DateTime dataPostagem, int quantidade)
        {
         
            Nome = nome;
            Preco = preco;
            DataPostagem = dataPostagem;
            Quantidade = quantidade;
        }
        public Livro()
        {

        }

        [Required]
        public string Nome { get; set; }

        [Required]
        public Decimal Preco { get; set; }

        [Required]
        public DateTime DataPostagem { get; set; }

        [Required]
        public int Quantidade { get; set; }

        public ICollection<Pedido> Pedidos { get; set; }
    }
}
