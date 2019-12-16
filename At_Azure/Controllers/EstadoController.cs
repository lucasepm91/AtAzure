using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using At_Azure.Models;
using At_Azure.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace At_Azure.Controllers
{    
    public class EstadoController : Controller
    {
        AtRepository repository = new AtRepository();
        BlobRepository blobs = new BlobRepository();

        // GET: Estado
        public ActionResult Index()
        {
            List<Estado> estados = repository.BuscarEstados();
            return View(estados);
        }

        // GET: Estado/Details/5
        public ActionResult Details(int id)
        {
            Estado estado = repository.BuscarEstado(id);
            return View(estado);
        }

        // GET: Estado/Create
        public ActionResult Create()
        {
            List<Pais> paises = repository.BuscarPaises();

            ViewData["Paises"] = new SelectList(paises, "Nome", "Nome");

            return View();
        }

        // POST: Estado/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind] Estado estado, IFormFile bandeiraEstado)
        {
            try
            {
                string nome = estado.Nome.Replace(" ", "");
                string nomeCompleto = nome + ".png";

                _ = blobs.ImportarBlob(bandeiraEstado, nomeCompleto);
                string caminho = blobs.BuscarCaminho(nomeCompleto);

                estado.Bandeira = caminho;

                repository.CriarEstado(estado);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Estado/Edit/5
        public ActionResult Edit(int id)
        {
            Estado estado = repository.BuscarEstado(id);
            List<Pais> paises = repository.BuscarPaises();

            ViewData["Paises"] = new SelectList(paises, "Nome", "Nome");

            return View(estado);
        }

        // POST: Estado/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Estado estado, IFormFile bandeiraEstado)
        {
            try
            {
                if (bandeiraEstado != null)
                {
                    string nome = estado.Nome.Replace(" ", "");
                    string nomeCompleto = nome + ".png";
                    blobs.AlterarBlob(estado.Bandeira, bandeiraEstado, nomeCompleto);
                    string caminho = blobs.BuscarCaminho(nomeCompleto);
                    estado.Bandeira = caminho;
                }
                repository.AtualizarEstado(id, estado);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Estado/Delete/5
        public ActionResult Delete(int id)
        {
            Estado estado = repository.BuscarEstado(id);
            return View(estado);
        }

        // POST: Estado/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Estado estado)
        {
            try
            {
                Estado encontrado = repository.BuscarEstado(id);
                blobs.DeletarBlob(encontrado.Bandeira);
                repository.DeletarEstado(id);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}