using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Hangfire;
using Microsoft.AspNetCore.Mvc;
using ORPI.Web.BL.ServiceInterface;

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
            //BackgroundJob.Enqueue(() => Console.WriteLine("Job Executed"));
            RecurringJob.AddOrUpdate("opri", () => entityService.UpdateOpri(), Cron.MinuteInterval(3));
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
