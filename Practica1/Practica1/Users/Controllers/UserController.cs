using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Practica1.Common.Application.Dto;
using Practica1.Users.Application.Assembler;
using Practica1.Users.Application.Dto;
using Practica1.Users.Domain.Entity;
using Practica1.Users.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practica1.Users.Controllers
{
    [Route("v1/company/{companyId}/{userId}")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private readonly UserCreateAssembler _userCreateAssembler;

        public UserController(IUserRepository userRepository, UserCreateAssembler userCreateAssembler)
        {
            _userRepository = userRepository;
            _userCreateAssembler = userCreateAssembler;
        }

        [HttpPost]
        public IActionResult Create(long companyId, [FromBody] UserCreateDto userCreateDto)
        {
            userCreateDto.CompanyId = companyId;
            User user = _userCreateAssembler.toEntity(userCreateDto);
            _userRepository.Create(user);
            return StatusCode(StatusCodes.Status201Created, new ApiStringResponseDto("User Created!"));
        }
    }
}
