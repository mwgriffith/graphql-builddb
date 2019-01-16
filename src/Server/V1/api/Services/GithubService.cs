using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Database;
using Microsoft.AspNetCore.Mvc;
using Server.api.Models.GitHub;
using Database.Entities.Github;
using Newtonsoft.Json;

namespace Server.V1.api.Services
{
    public class GithubService : IGithubService
    {
        private readonly BuildDBContext _buildDBContext;

        public GithubService(BuildDBContext buildDBContext)
        {
            _buildDBContext = buildDBContext;
        }


        /// <summary>
        /// Takes the github message and saves it to the db.
        /// </summary>
        /// <param name="message">The github message that was sent.</param>
        /// <returns>An actionresult depending upon how it went.</returns>
        public ActionResult AddGithubMessage(GithubPush message)
        {
            using (var transaction = _buildDBContext.Database.BeginTransaction())
            {
                try
                {
                    var commit = new Server.api.Models.GitHub.Commit
                    {
                        message = JsonConvert.SerializeObject(message)
                    };

                    _buildDBContext.Add(commit);
                    _buildDBContext.SaveChanges();

                    transaction.Commit();
                    return new OkObjectResult(new { message = "200 OK", currentDate = DateTime.Now });
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    return new BadRequestObjectResult(new { message = "500 Server Error", currentDate = DateTime.Now });
                }
            }
        }
    }
}
