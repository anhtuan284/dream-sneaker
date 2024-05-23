﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using QLBG.BLL;
using QLBG.Common.Req;

namespace QLBG.WEB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoeController : Controller
    {
        ShoeSvc shoeSvc = new ShoeSvc();
        [HttpPost("create")]
        public IActionResult CreateTag([FromBody] ShoeReq shoeReq)
        {
            var res = shoeSvc.CreateShoe(shoeReq);
            return Created(new Uri(Request.GetEncodedUrl()), res);
        }
    }
}
