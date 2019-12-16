using At_Azure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace At_Azure.Repository
{
    public class AtRepository
    {
        private AmigoRepository amigoRepository = new AmigoRepository();
        private LocalidadeRepository localidadeRepository = new LocalidadeRepository();

        public List<Amigo> BuscarAmigos()
        {
            List<Amigo> amigos = null;
            HttpResponseMessage response = amigoRepository.GetResponse("api/amigo");

            if(response.IsSuccessStatusCode)
            {
                amigos = response.Content.ReadAsAsync<List<Amigo>>().Result;
            }

            return amigos;
        }

        public Amigo BuscarAmigo(int id)
        {
            Amigo amigo = null;
            HttpResponseMessage response = amigoRepository.GetResponse("api/amigo/" + id);

            if (response.IsSuccessStatusCode)
            {
                amigo = response.Content.ReadAsAsync<Amigo>().Result;
            }

            return amigo;
        }

        public void CriarAmigo(Amigo amigo)
        {
            HttpResponseMessage response = amigoRepository.PostResponse("api/amigo", amigo);
        }

        public void AtualizarAmigo(int id, Amigo amigo)
        {
            HttpResponseMessage response = amigoRepository.PutResponse("api/amigo/" + id, amigo);
        }

        public void DeletarAmigo(int id)
        {
            HttpResponseMessage response = amigoRepository.DeleteResponse("api/amigo/" + id);
        }

        public List<Pais> BuscarPaises()
        {
            List<Pais> paises = null;
            HttpResponseMessage response = localidadeRepository.GetResponse("api/pais");

            if (response.IsSuccessStatusCode)
            {
                paises = response.Content.ReadAsAsync<List<Pais>>().Result;
            }

            return paises;
        }

        public Pais BuscarPais(int id)
        {
            Pais pais = null;
            HttpResponseMessage response = localidadeRepository.GetResponse("api/pais/" + id);

            if (response.IsSuccessStatusCode)
            {
                pais = response.Content.ReadAsAsync<Pais>().Result;
            }

            return pais;
        }

        public void CriarPais(Pais pais)
        {
            HttpResponseMessage response = localidadeRepository.PostResponse("api/pais", pais);
        }

        public void AtualizarPais(int id, Pais pais)
        {
            HttpResponseMessage response = localidadeRepository.PutResponse("api/pais/" + id, pais);
        }

        public void DeletarPais(int id)
        {
            HttpResponseMessage response = localidadeRepository.DeleteResponse("api/pais/" + id);
        }

        public List<Estado> BuscarEstados()
        {
            List<Estado> estados = null;
            HttpResponseMessage response = localidadeRepository.GetResponse("api/estado");

            if (response.IsSuccessStatusCode)
            {
                estados = response.Content.ReadAsAsync<List<Estado>>().Result;
            }

            return estados;
        }

        public Estado BuscarEstado(int id)
        {
            Estado estado = null;
            HttpResponseMessage response = localidadeRepository.GetResponse("api/estado/" + id);

            if (response.IsSuccessStatusCode)
            {
                estado = response.Content.ReadAsAsync<Estado>().Result;
            }

            return estado;
        }

        public void CriarEstado(Estado estado)
        {
            HttpResponseMessage response = localidadeRepository.PostResponse("api/estado", estado);
        }

        public void AtualizarEstado(int id, Estado estado)
        {
            HttpResponseMessage response = localidadeRepository.PutResponse("api/estado/" + id, estado);
        }

        public void DeletarEstado(int id)
        {
            HttpResponseMessage response = localidadeRepository.DeleteResponse("api/estado/" + id);
        }

        public List<Estado> BuscarEstadosDoPais(string nomePais)
        {
            List<Estado> estados = null;

            HttpResponseMessage response = localidadeRepository.GetResponse("api/estado/pais/" + nomePais);

            if (response.IsSuccessStatusCode)
            {
                estados = response.Content.ReadAsAsync<List<Estado>>().Result;
                if (estados.Count < 1)
                    estados = null;
            }

            return estados;
        }

        public void QtdEntidades(out int numAmigos, out int numPaises, out int numEstados)
        {
            List<Amigo> amigos = null;
            List<Pais> paises = null;
            List<Estado> estados = null;
            HttpResponseMessage response = null;

            numAmigos = 0;
            numPaises = 0;
            numEstados = 0;

            response = amigoRepository.GetResponse("api/amigo");

            if(response.IsSuccessStatusCode)
            {
                amigos = response.Content.ReadAsAsync<List<Amigo>>().Result;
                numAmigos = amigos.Count;
            }

            response = localidadeRepository.GetResponse("api/pais");

            if (response.IsSuccessStatusCode)
            {
                paises = response.Content.ReadAsAsync<List<Pais>>().Result;
                numPaises = paises.Count;
            }

            response = localidadeRepository.GetResponse("api/estado");

            if (response.IsSuccessStatusCode)
            {
                estados = response.Content.ReadAsAsync<List<Estado>>().Result;
                numEstados = estados.Count;
            }
        }

    }
}
