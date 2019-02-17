using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Database;
using Server.V1.api.Models.Bitbucket;
using Server.V1.api.Services;

namespace Server.V1.api.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]/[action]")]
    [ApiController]
    public class BitbucketController : ControllerBase
    {        
        private readonly IBitbucketService _bitbucketService;

        public BitbucketController(IBitbucketService bitbucketService)
        {
            _bitbucketService = bitbucketService;
        }


        /// <summary>
        /// takes a bitbucket message and handles it.
        /// </summary>
        /// <param name="bitbucketPush">The bitbucket message sent for the push.</param>
        /// <returns>An actionresult.</returns>
        [HttpPost]
        public ActionResult Update([FromBody] BitbucketPush bitbucketPush)
        {
            return _bitbucketService.AddBitbucketMessage(bitbucketPush);
        }
    }
}