using System;
using System.Collections.Generic;
using System.Text;

namespace Database.Entities.TeamCity
{
    public class Build
    {
        public string href { get; set; }
        public string webUrl { get; set; }
        public string state { get; set; }
        public string status { get; set; }
        public int number { get; set; }
        public string buildTypeId { get; set; }
        public string id { get; set; }
    }
}
