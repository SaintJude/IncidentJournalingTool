using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IncidentJournalingTool.Models
{
    public class IncidentModel
    {
        public string ID { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreateUser { get; set; }
        public string Title { get; set; }
    }
}