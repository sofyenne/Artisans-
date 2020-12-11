using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Artisan.Dbcontext;
using Artisan.Entity;
using Artisan.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Artisan.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReclamationController : ControllerBase
    {
        private readonly Datacontextcs _context;
        private IReclamationService _reclamationService;


        public ReclamationController(Datacontextcs context  , IReclamationService reclamationService)
        {

            _context = context;
            _reclamationService = reclamationService;
        }

        [HttpGet("affiche")]
        public async Task<IActionResult> getall()
        {
            var rec = await _reclamationService.getallrec();
            return Ok(rec);
        }

       
        [HttpPost("Create")]
        public async Task<IActionResult>create(Reclamations reclamations) 
        {
            if (!ModelState.IsValid)
                return BadRequest();
            var rec = await _reclamationService.createrec(reclamations);
            return Ok(rec);
        }
        [HttpDelete("deleterec")]
        public async Task<IActionResult>deleterec(int id)
        {
            var rec = await _reclamationService.deleterec(id);
            return Ok(rec);
        }
        
    }

}

