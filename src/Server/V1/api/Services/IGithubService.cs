using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Server.V1.api.Models.GitHub;

namespace Server.V1.api.Services
{
    public interface IGithubService
    {
        ActionResult AddGithubMessage(GithubPush message);
    }
}
