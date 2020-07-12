using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Prestamo_API.BLL;
using Prestamo_API.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PrestamoWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonasController : ControllerBase
    {
        // GET api/<PersonasController>
        [HttpGet]
        public ActionResult<List<Personas>> Get()
        {
            return PersonasBLL.GetPersonas();

        }

        // GET api/<PersonasController>/5
        [HttpGet("{id}")]
        public ActionResult<List<Personas>> Get(int id)
        {
            return PersonasBLL.GetPersonas();
        }

        // POST api/<PersonasController>
        [HttpPost]
        public void Post([FromBody] Personas Persona)
        {
            PersonasBLL.Guardar(Persona);
        }

        // DELETE api/<PersonasController>/5s
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            PersonasBLL.Eliminar(id);
        }
    }
}
