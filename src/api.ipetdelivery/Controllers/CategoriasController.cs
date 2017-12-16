using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using api.ipetdelivery.Models;
using api.ipetdelivery.Application;

namespace api.ipetdelivery.Controllers
{
    [Route("api/v1/categorias")]
    public class CategoriasController : Controller
    {
        private readonly CategoriaApplication _CategoriaApplication = null;
        private readonly ParceiroApplication _ParceiroApplication = null;

        public CategoriasController(CategoriaApplication CategoriaApplication, ParceiroApplication ParceiroApplication)
        {
            _CategoriaApplication = CategoriaApplication;
            _ParceiroApplication = ParceiroApplication;
        }
        [HttpGet]
        public IEnumerable<Categoria> getCategorias()
        {
            return _CategoriaApplication.get();
        }
        [HttpGet("id/{categoria}")]
        public IEnumerable<Parceiro> getParceirosPorCategoria(int categoria)
        {
            return _ParceiroApplication.getParceirosPorCategoria(categoria);
        }
    }
}
