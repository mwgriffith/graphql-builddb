using Microsoft.AspNetCore.Mvc;

using Server.V1.api.Models.Bitbucket;


namespace Server.V1.api.Services
{
    public interface IBitbucketService
    {
        ActionResult AddBitbucketMessage(BitbucketPush message);
    }
}
