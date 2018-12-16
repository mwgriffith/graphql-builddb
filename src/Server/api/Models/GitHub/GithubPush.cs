using System.Collections.Generic;
using Newtonsoft.Json;

namespace Server.api.Models.GitHub
{
    public class GithubPush
    {
        [JsonProperty("ref")]
        public string _ref { get; set; }
        public string before { get; set; }
        public string after { get; set; }
        public bool created { get; set; }
        public bool deleted { get; set; }
        public bool forced { get; set; }
        public object base_ref { get; set; }
        public string compare { get; set; }
        public IList<Commit> commits { get; set; }
        public HeadCommit head_commit { get; set; }
        public Repository repository { get; set; }
        public Pusher pusher { get; set; }
        public Sender sender { get; set; }
    }
}
