using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            // get configuration values
            string siteName = Startup.configReader.GetValue<string>("SiteName");
            int requestCount = Startup.configReader.GetValue<int>("RequestCount");
            double sampleDoubleConfiguration = Startup.configReader.GetValue<double>("SampleDoubleConfiguration");
            bool sampleBooleanConfiguration = Startup.configReader.GetValue<bool>("SampleBooleanConfiguration");

            return new string[] {  siteName, requestCount.ToString(), sampleDoubleConfiguration.ToString(), sampleBooleanConfiguration.ToString() };
        }


    }
}
