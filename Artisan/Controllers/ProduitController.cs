using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Artisan.Dbcontext;
using Artisan.Entity;
using Artisan.Services;
using Artisan.Setting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace Artisan.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProduitController : ControllerBase
    {
        private readonly Datacontextcs _context;
        private IProduitService _produitService;


        public ProduitController(Datacontextcs context , IProduitService produitServices )
        {
            _context = context;
            _produitService = produitServices;
           
        }

        [HttpGet("affiche")]
        public async Task<IActionResult> getall()
        {
            var prod = await _produitService.getallprod();
            return Ok(prod);
        }

        [HttpGet("prodById/{x}")]
        public async Task<IActionResult> getbyid(int x )
        {
            var prod = await _produitService.getprodbyid(x);
            return Ok(prod);

        }

        [HttpGet("prodByIdcat/{x}")]
        public async Task<IActionResult> getbyidcat(int x)
        {
            var prod = await _produitService.getprodbyidcat(x);
            return Ok(prod);

        }

        [HttpPost("ajoute")]
        public async Task<IActionResult>createprod( Produit produit)
        {
           
            var prod = await _produitService.createprod(produit);
            return Ok(prod); 
        }

        [HttpDelete("sup/{id}")]
        public async Task<IActionResult>delete(int id)
        {
            var prod = await _produitService.deleteprod(id);

            return Ok(prod);
        }
    }
}
