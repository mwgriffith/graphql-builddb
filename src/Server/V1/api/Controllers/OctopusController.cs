using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Database;
using Server.V1.api.Models.Octopus;

namespace Server.V1.api.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
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