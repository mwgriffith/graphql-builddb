using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Database;
using Server.api.Models.GitHub;


namespace Server.api.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class GithubController : ControllerBase
    {
        private readonly BuildDBContext _buildDBContext;

        public GithubController(BuildDBContext buildDBContext)
        {
            _buildDBContext = buildDBContext;
        }

        
        //public async Task<ActionResult> Update([FromBody] GithubPush githubPush)
        //{

        //}

    }
}