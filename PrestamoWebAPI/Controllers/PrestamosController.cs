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
    public class PrestamosController : ControllerBase
    {
        // GET api/<PrestamosController>
        [HttpGet]
        public ActionResult<List<Prestamos>> Get()
        {
            return PrestamosBLL.GetPrestamo();
        }

        // GET api/<PrestamosController>/5
        [HttpGet("{id}")]
        public ActionResult<List<Prestamos>> Get(int id)
        {
            return PrestamosBLL.GetPrestamo();
        }

        // POST api/<PrestamosController>
        [HttpPost]
        public void Post([FromBody] Prestamos Prestamo)
        {
            PrestamosBLL.Guardar(Prestamo);
        }

        // DELETE api/<PrestamosController>/5s
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            PrestamosBLL.Eliminar(id);
        }
    }
}
