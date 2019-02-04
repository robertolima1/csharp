using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotecaTeca.Models
{
    public class Aluguel : BaseModel
    {
        public Aluguel(DateTime dataAluguel)
        {
            DataAluguel = dataAluguel;   
        }

        [Required]
        public DateTime DataAluguel { get; set; } = new DateTime();

        [Required]
        public List<Pedido> Pedidos { get; set; }

        [Required]
        public Cliente Cliente { get; set; }
    }
}
