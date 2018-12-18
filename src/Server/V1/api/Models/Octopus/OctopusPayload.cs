using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.api.Models.Octopus
{
    public class OctopusPayload
    {
        public string ServerUri { get; set; }
        public string ServerAuditUri { get; set; }
        public string Subscription { get; set; }    // TODO find the right object.
        public string Event { get; set; }   // TODO find the right object.
        public DateTime BatchProcessingDate { get; set; }
        public string BatchId { get; set; }
        public int TotalEventsInBatch { get; set; }
        public int EventNumberInBatch { get; set; }
    }
}
