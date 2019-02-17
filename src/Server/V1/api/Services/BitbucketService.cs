using System;
using Database;
using Microsoft.AspNetCore.Mvc;
using Server.V1.api.Models.Bitbucket;
using Database.Entities.Bitbucket;
using Newtonsoft.Json;


namespace Server.V1.api.Services
{
    public class BitbucketService : IBitbucketService
    {
        private readonly BuildDBContext _buildDBContext;

        public BitbucketService(BuildDBContext buildDBContext)
        {
            _buildDBContext = buildDBContext;
        }


        /// <summary>
        /// Takes the bitbucket message and saves it to the db.
        /// </summary>
        /// <param name="message">The bitbucket message that was sent.</param>
        /// <returns>An actionresult depending upon how it went.</returns>
        public ActionResult AddBitbucketMessage(BitbucketPush message)
        {
            using (var transaction = _buildDBContext.Database.BeginTransaction())
            {
                try
                {
                    var commit = new Database.Entities.Bitbucket.Push
                    {
                        PushMessage = JsonConvert.SerializeObject(message)
                    };

                    _buildDBContext.Add(commit);
                    _buildDBContext.SaveChanges();

                    transaction.Commit();
                    return new OkObjectResult(new { message = "200 OK", currentDate = DateTime.Now });
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    return new BadRequestObjectResult(new { message = "500 Server Error", currentDate = DateTime.Now });
                }
            }
        }    
    }
}
