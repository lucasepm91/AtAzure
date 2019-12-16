using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using At_Azure.Models;
using At_Azure.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace At_Azure.Controllers
{
    public class PaisController : Controller
    {
        AtRepository repository = new AtRepository();
        BlobRepository blobs = new BlobRepository();

        // GET: Pais
        public ActionResult Index()
        {
            List<Pais> paises = repository.BuscarPaises();
            return View(paises);
        }

        // GET: Pais/Details/5
        public ActionResult Details(int id)
        {
            Pais pais = repository.BuscarPais(id);
            List<Estado> estadosDoPais = repository.BuscarEstadosDoPais(pais.Nome);

            ViewBag.Estados = estadosDoPais;

            return View(pais);
        }

        // GET: Pais/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pais/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind] Pais pais, IFormFile bandeira)
        {
            try
            {                
                string nome = pais.Nome.Replace(" ", "");
                string nomeCompleto = nome + ".png";

                _= blobs.ImportarBlob(bandeira, nomeCompleto);
                string caminho = blobs.BuscarCaminho(nomeCompleto);
                pais.Bandeira = caminho;

                repository.CriarPais(pais);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Pais/Edit/5
        public ActionResult Edit(int id)
        {
            Pais pais = repository.BuscarPais(id);
            return View(pais);
        }

        // POST: Pais/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Pais pais, IFormFile bandeira)
        {
            try
            {
                if (bandeira != null)
                {
                    string nome = pais.Nome.Replace(" ", "");
                    string nomeCompleto = nome + ".png";
                    blobs.AlterarBlob(pais.Bandeira,bandeira, nomeCompleto);
                    string caminho = blobs.BuscarCaminho(nomeCompleto);
                    pais.Bandeira = caminho;                    
                }
                repository.AtualizarPais(id, pais);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Pais/Delete/5
        public ActionResult Delete(int id)
        {
            Pais pais = repository.BuscarPais(id);
            return View(pais);
        }

        // POST: Pais/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Pais pais)
        {
            try
            {
                Pais encontrado = repository.BuscarPais(id);
                blobs.DeletarBlob(encontrado.Bandeira);
                repository.DeletarPais(id);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}