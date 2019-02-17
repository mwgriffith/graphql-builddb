using Microsoft.AspNetCore.Mvc;

using Server.V1.api.Models.GitHub;

namespace Server.V1.api.Services
{
    public interface IGithubService
    {
        ActionResult AddGithubMessage(GithubPush message);
    }
}
