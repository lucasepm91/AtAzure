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
    public class AmigoController : Controller
    {
        AtRepository repository = new AtRepository();
        BlobRepository blobs = new BlobRepository();
        // GET: Amigo
        public ActionResult Index()
        {
            List<Amigo> amigos = repository.BuscarAmigos();
            return View(amigos);
        }

        // GET: Amigo/Details/5
        public ActionResult Details(int id)
        {
            Amigo amigo = repository.BuscarAmigo(id);
            return View(amigo);
        }

        // GET: Amigo/Create
        public ActionResult Create()
        {
            List<Pais> paises = repository.BuscarPaises();
            List<Estado> estados = repository.BuscarEstados();

            ViewData["Paises"] = new SelectList(paises, "Nome", "Nome");
            ViewData["Estados"] = new SelectList(estados, "Nome", "Nome");

            return View();
        }

        // POST: Amigo/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind] Amigo amigo, IFormFile foto)
        {
            try
            {
                string nome = amigo.Nome.Replace(" ","") + amigo.Sobrenome.Replace(" ", "");
                string nomeCompleto = nome + ".png";

                _ = blobs.ImportarBlob(foto, nomeCompleto);
                string caminho = blobs.BuscarCaminho(nomeCompleto);
                amigo.Foto = caminho;                

                repository.CriarAmigo(amigo);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Amigo/Edit/5
        public ActionResult Edit(int id)
        {
            Amigo amigo = repository.BuscarAmigo(id);
            List<Pais> paises = repository.BuscarPaises();
            List<Estado> estados = repository.BuscarEstados();

            ViewData["Paises"] = new SelectList(paises, "Nome", "Nome");
            ViewData["Estados"] = new SelectList(estados, "Nome", "Nome");

            return View(amigo);
        }

        // POST: Amigo/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Amigo amigo, IFormFile foto)
        {
            try
            {
                amigo.Id = id;
                if (foto != null)
                {
                    string nome = amigo.Nome.Replace(" ", "") + amigo.Sobrenome.Replace(" ", "");
                    string nomeCompleto = nome + ".png";
                    blobs.AlterarBlob(amigo.Foto, foto, nomeCompleto);
                    string caminho = blobs.BuscarCaminho(nomeCompleto);
                    amigo.Foto = caminho;
                    
                }
                repository.AtualizarAmigo(id, amigo);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Amigo/Delete/5
        public ActionResult Delete(int id)
        {
            Amigo amigo = repository.BuscarAmigo(id);
            return View(amigo);
        }

        // POST: Amigo/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Amigo amigo)
        {
            try
            {
                Amigo encontrado = repository.BuscarAmigo(id);
                blobs.DeletarBlob(encontrado.Foto);

                repository.DeletarAmigo(id);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}