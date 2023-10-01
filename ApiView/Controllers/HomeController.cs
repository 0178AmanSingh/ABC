using ApiView.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
namespace ApiView.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            List<Api> apidata = new List<Api>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(" http://localhost:23523/api/Api/GetApiData"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    apidata = JsonConvert.DeserializeObject<List<Api>>(apiResponse);
                }
            }
            return View(apidata);
        }

    }
}
