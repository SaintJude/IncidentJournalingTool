using IncidentJournalingTool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IncidentJournalingTool.Services
{
    public class IncidentService
    {
        public IEnumerable<IncidentModel> GetByID (string ID)
        {
            IncidentModel mod = new IncidentModel()
            {
                CreateDateTime = DateTime.Now,
                CreateUser = "Bars03",
                ID = "1",
                Title = "Title",
            };
            return new List<IncidentModel>() { mod };
        }
        public IEnumerable<IncidentModel> GetByDate(DateTime date)
        {
            IncidentModel mod = new IncidentModel()
            {
                CreateDateTime = DateTime.Now,
                CreateUser = "Bars03",
                ID = "1",
                Title = "Title",
            };
            return new List<IncidentModel>() { mod };
        }
        public IncidentModel Create(IncidentModel model)
        {
            return model;
        }
    }
}