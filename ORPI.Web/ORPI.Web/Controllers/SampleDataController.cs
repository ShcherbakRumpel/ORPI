using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hangfire;
using Microsoft.AspNetCore.Mvc;
using ORPI.Web.BL.ServiceInterface;

namespace ORPI.Web.Controllers
{
    [Route("api/[controller]")]
    public class SampleDataController : Controller
    {
        private IEntityService entityService;
        public SampleDataController(IEntityService _entityService)
        {
            entityService = _entityService;
        }

        private static string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        [HttpGet("Job")]
        public IActionResult Job()
        {
            //BackgroundJob.Enqueue(() => entityService.UpdateOpri());
            //RecurringJob.AddOrUpdate(() => entityService.UpdateOpri(), Cron.Daily);
            RecurringJob.AddOrUpdate(() => entityService.UpdateOpri(), Cron.DayInterval(1));
            return Ok();
        }

        [HttpGet("GetAdFiles")]
        public IActionResult GetAdFiles()
        {
            var result = entityService.GetAllAdFile();
            return Ok(result);
        }

        [HttpGet("ManualUpdateAgency")]
        public IActionResult ManualUpdateAgency()
        {
            var result = entityService.ManualUpdateAgency();
            return Ok(result);
        }

        [HttpGet("ManualUpdateAdFile")]
        public IActionResult ManualUpdateAdFile()
        {
            var result = entityService.ManualUpdateAdFile();
            return Ok(result);
        }

        [HttpGet("[action]")]
        public IEnumerable<WeatherForecast> WeatherForecasts()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                DateFormatted = DateTime.Now.AddDays(index).ToString("d"),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            });
        }

        public class WeatherForecast
        {
            public string DateFormatted { get; set; }
            public int TemperatureC { get; set; }
            public string Summary { get; set; }

            public int TemperatureF
            {
                get
                {
                    return 32 + (int)(TemperatureC / 0.5556);
                }
            }
        }
    }
}
