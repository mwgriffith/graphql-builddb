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
    [Route("api/[controller]")]
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