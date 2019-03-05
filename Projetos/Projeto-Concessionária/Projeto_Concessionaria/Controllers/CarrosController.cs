using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Projeto_Concessionaria.Models;

namespace Projeto_Concessionaria.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class CarrosController : ControllerBase
    {

        private readonly ICarroService carroService;

        public CarrosController(ICarroService carroService)
        {
            this.carroService = carroService;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<List<Carro>> GetCarros()
        {
            return this.carroService.Get();
        }

        [HttpPost]
        public ActionResult Create(Carro carro)
        {
            this.carroService.Insert(carro);
            return Ok("Foi criado o carro" + carro.Nome);
        }

        [HttpDelete]
        public ActionResult Delete(String Idcarro)
        {
            this.carroService.Remove(Idcarro);
            return Ok("Foi deletado o carro" + Idcarro);
        }


        [HttpDelete]
        public ActionResult Update(Carro carro)
        {
            this.carroService.Update(carro);
            return Ok("Foi atualizado o carro" + carro.Nome);
        }
    }
}
