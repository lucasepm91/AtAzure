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
    public class PaisController : ControllerBase
    {
        LocalidadeRepository repository = new LocalidadeRepository();

        // GET: api/Pais
        [HttpGet]
        public IEnumerable<Pais> Get()
        {
            List<Pais> paises = repository.BuscarPaises();

            return paises;
        }

        // GET: api/Pais/5
        [HttpGet("{id}")]
        public Pais Get(int id)
        {
            Pais pais = repository.BuscarPais(id);

            return pais;
        }

        // POST: api/Pais
        [HttpPost]
        public void Post([FromBody] Pais pais)
        {
            repository.CriarPais(pais);
        }

        // PUT: api/Pais/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Pais pais)
        {
            repository.AtualizarPais(id, pais);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            repository.DeletarPais(id);
        }
    }
}
