using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace simple_sample_rc2.Controllers
{
    public class Hello : Controller
    {
        public IConfiguration Configuration { get; }

        // GET: /<controller>/
        public string Index()
        {
            return $"The connection string is {Startup.ConnectionString}";
            // Test Sync
        }
    }
}