using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Database;
using Server.api.Models.Octopus;

namespace Server.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OctopusController : ControllerBase
    {
        private readonly BuildDBContext _buildDBContext;

        public OctopusController(BuildDBContext buildDBContext)
        {
            _buildDBContext = buildDBContext;
        }


        //[HttpPost]
        //public async Task<ActionResult> Update([FromBody] OctopusWebhookInfo octopusWebhookInfo)
        //{

        //}
    }
}