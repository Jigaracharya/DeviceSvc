using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DeviceSvc.API.Controllers
{
    public class DevicesController : Controller
    {
        // GET: DevicesController
        public ActionResult Get()
        {
            return Ok(new { Name = "Jigar Acharya" });
        }

    }
}
