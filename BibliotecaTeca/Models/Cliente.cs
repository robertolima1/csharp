using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace BibliotecaTeca.Models
{
    [DataContract]
    public class Cliente: BaseModel
    {
        public Cliente( string nome, string email)
        {            
            Nome = nome;
            Email = email;           
        }

        [Required]
        public string Nome { get; set; }
        [Required]
        public string Email { get; set; }

        [Required]
        public List<Aluguel> Alugueis { get; set; }

    }
}
