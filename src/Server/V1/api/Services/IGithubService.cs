using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Server.api.Models.GitHub;

namespace Server.V1.api.Services
{
    public interface IGithubService
    {
        ActionResult AddGithubMessage(GithubPush message);
    }
}
