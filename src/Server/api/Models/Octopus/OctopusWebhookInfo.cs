using System;


namespace Server.api.Models.Octopus
{
    public class OctopusWebhookInfo
    {
        public DateTime Timestamp { get; set; }
        public string EventType { get; set; }
        public OctopusPayload Payload { get; set; }
    }
}
