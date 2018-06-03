using System.Collections.Generic;
using Quiniela.Services;
using Microsoft.AspNetCore.Mvc;

namespace Quiniela.Controllers
{
    [Route("api/[controller]")]
    public class QuinielaController : Controller
    {
        IQuinielaServices _quinielaService;
        public QuinielaController(IQuinielaServices quinielaService)
        {
            _quinielaService = quinielaService;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "ok", "up" };
        }

        [HttpGet("{id}")]
        public IActionResult GetUser(long id){
            this._quinielaService.GetUser(id);
            return Ok(id);
        }
    }
}
