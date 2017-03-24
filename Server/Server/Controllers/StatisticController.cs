using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Mvc;
using Server.Models;

namespace Server.Controllers
{
    [System.Web.Http.RoutePrefix("statistic")]
    public class StatisticController : ApiController
    {
        private ApplicationDbContext context;

        public StatisticController()
        {
            context = new ApplicationDbContext();
        }
        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("steps/{username}")]
        public ICollection<Statistic> Steps(string username)
        {
            ApplicationUser user = context.Users.FirstOrDefault(x => x.UserName == username);
            if (user == null)
            {
                BadRequest("The username is not valid");
                throw new ArgumentException("Invaild username");
            }
            return user.Statistics;
        }

        [System.Web.Http.HttpPost]
        [System.Web.Http.Route("steps/{username}")]
        public void Steps([Bind(Include = "Date,Steps")] StatisticBindingModel bindingModel,string username)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser user = context.Users.FirstOrDefault(u => u.UserName == username);
                if (user == null)
                {
                    throw new ArgumentException("The username is invalid");
                }
                Statistic statistic = new Statistic()
                {
                    Date = bindingModel.Date,
                    Steps = bindingModel.Steps
                };
                user.Statistics.Add(statistic);
                context.SaveChanges();
            }
        }
    }
}
