using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using ApiAmigo.Domain;
using ApiAmigo.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiAmigo.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class AmigoController : ControllerBase
    {        
        AmigoRepository repository = new AmigoRepository();

        // GET: api/Amigo
        [HttpGet]
        public IEnumerable<Amigo> Get()
        {
            List<Amigo> amigos;

            amigos = repository.BuscarAmigos();

            return amigos;
        }

        // GET: api/Amigo/5
        [HttpGet("{id}", Name = "Get")]
        public Amigo Get(int id)
        {
            Amigo amigo = null;

            amigo = repository.BuscarAmigo(id);

            return amigo;
        }

        // POST: api/Amigo
        [HttpPost]
        public void Post([FromBody] Amigo amigo)
        {
            repository.CriarAmigo(amigo);
        }

        // PUT: api/Amigo/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Amigo amigo)
        {
            repository.AtualizarAmigo(id, amigo);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            repository.DeletarAmigo(id);
        }
    }
}
