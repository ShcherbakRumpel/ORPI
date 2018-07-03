using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Hangfire;
using Microsoft.AspNetCore.Mvc;
using ORPI.Web.BL.ServiceInterface;
using ORPI.Web.BL.Services;

namespace ORPI.Web.Controllers
{
    public class HomeController : Controller
    {
        private IEntityService entityService;
        public HomeController(IEntityService _entityService)
        {
            entityService = _entityService;
        }

        public IActionResult Index()
        {
            //var options = new BackgroundJobServerOptions
            //{
            //    SchedulePollingInterval = TimeSpan.FromMinutes(10)
            //};

            //var server = new BackgroundJobServer(options);

            //BackgroundJob.Schedule(
            //    () => entityService.UpdateOpri(),
            //    TimeSpan.FromMinutes(10));

        //    BackgroundJob.Enqueue<EntityService>(x => x.UpdateOpri());


            //BackgroundJob.Enqueue(() => Console.WriteLine("Job Executed"));

            //RecurringJob.AddOrUpdate("opri", () => entityService.UpdateOpri(), Cron.Daily);

            //BackgroundJob.Enqueue(() => Console.WriteLine("Fire-and-forget Job Executed"));
            ////BackgroundJob.Schedule(() => Console.Write(1), TimeSpan.FromMinutes(1));
            //RecurringJob.AddOrUpdate(() => Console.WriteLine("Minutely Job executed"), Cron.Minutely);
            return View();
        }

        public IActionResult Error()
        {
            ViewData["RequestId"] = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
            return View();
        }
    }
}
