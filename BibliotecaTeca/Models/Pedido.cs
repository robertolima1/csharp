﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace BibliotecaTeca.Models
{
    [DataContract]
    public class Pedido : BaseModel
    {
        public Pedido()
        {            
                 
        }
        
        [Required]
        public List<Livro> Livros { get; set; }


        [Required]
        public Aluguel Aluguel { get; set; }

    }
}
