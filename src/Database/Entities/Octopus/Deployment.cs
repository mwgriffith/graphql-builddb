using System;
using System.Collections.Generic;
using System.Text;

namespace Database.Entities.Octopus
{
    public class Deployment
    {
        public string DeploymentId { get; set; }
        public string DeploymentName { get; set; }
        public string ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string ProjectSlug { get; set; }
        public string TenantId { get; set; }
        public string TenantName { get; set; }
        public string ChannelId { get; set; }
        public string ChannelName { get; set; }
        public string EnvironmentId { get; set; }
        public string EnvironmentName { get; set; }
        public string ReleaseId { get; set; }
        public string ReleaseVersion { get; set; }
        public string TaskId { get; set; }
        public string TaskState { get; set; }
        public DateTime Created { get; set; }
        public DateTime QueueTime { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime CompletedTime { get; set; }
        public int DuractionSeconds { get; set; }
        public string DeployedBy { get; set; }
    }
}
