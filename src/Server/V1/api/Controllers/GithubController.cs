using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Database;
using Server.api.Models.GitHub;
using Server.V1.api.Services;


namespace Server.api.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class GithubController : ControllerBase
    {
        private readonly IGithubService _githubService;

        public GithubController(IGithubService githubService)
        {
            _githubService = githubService;
        }


        /// <summary>
        /// takes a github message and handles it.
        /// </summary>
        /// <param name="githubPush">The github message sent for the push.</param>
        /// <returns>An actionresult.</returns>
        public ActionResult Update([FromBody] GithubPush githubPush)
        {
            return _githubService.AddGithubMessage(githubPush);
        }

    }
}

