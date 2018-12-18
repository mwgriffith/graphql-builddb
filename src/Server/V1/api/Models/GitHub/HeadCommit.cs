using System;
using System.Collections.Generic;


namespace Server.api.Models.GitHub
{
    public class HeadCommit
    {
        public string id { get; set; }
        public string tree_id { get; set; }
        public bool distinct { get; set; }
        public string message { get; set; }
        public DateTime timestamp { get; set; }
        public string url { get; set; }
        public Author author { get; set; }
        public Committer committer { get; set; }
        public IList<object> added { get; set; }
        public IList<object> removed { get; set; }
        public IList<string> modified { get; set; }
    }
}
