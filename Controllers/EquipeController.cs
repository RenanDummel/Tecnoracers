using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace Site
{
    [ApiController]
    [Route("[controller]")]
    public class EquipeController : ControllerBase
    {
        Context db = new Context();

        [HttpGet]
        public IEnumerable<Equipe> ListAccounts()
        {
            return db.Equipe.ToList();
        }
    }
}