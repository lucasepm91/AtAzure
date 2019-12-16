using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiPaises.Domain;
using ApiPaises.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiPaises.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class EstadoController : ControllerBase
    {
        LocalidadeRepository repository = new LocalidadeRepository();

        // GET: api/Estado
        [HttpGet]
        public IEnumerable<Estado> Get()
        {
            List<Estado> estados = repository.BuscarEstados();

            return estados;
        }

        [HttpGet("pais/{nomePais}")]
        public IEnumerable<Estado> Get([FromRoute] string nomePais)
        {
            List<Estado> estados = repository.BuscarEstadosDoPais(nomePais);

            return estados;
        }

        // GET: api/Estado/5
        [HttpGet("{id}")]
        public Estado Get(int id)
        {
            Estado estado = repository.BuscarEstado(id);

            return estado;
        }

        // POST: api/Estado
        [HttpPost]
        public void Post([FromBody] Estado estado)
        {
            repository.CriarEstado(estado);
        }

        // PUT: api/Estado/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Estado estado)
        {
            repository.AtualizarEstado(id, estado);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            repository.DeletarEstado(id);
        }
    }
}
