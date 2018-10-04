using Microsoft.AspNetCore.Mvc;
using Practica1.Common.Application.Dto;
using System;

namespace Practica1.Common.Controllers
{
    [Produces("application/json")]
    [Route("")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public Object Get()
        {
            return new ApiStringResponseDto("api root endpoint");
        }
    }
}
