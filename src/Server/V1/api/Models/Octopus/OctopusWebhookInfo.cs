using System;


namespace Server.V1.api.Models.Octopus
{
    public class OctopusWebhookInfo
    {
        public DateTime Timestamp { get; set; }
        public string EventType { get; set; }
        public OctopusPayload Payload { get; set; }
    }
}
