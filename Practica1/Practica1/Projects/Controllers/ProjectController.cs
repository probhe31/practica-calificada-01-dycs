using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Practica1.Common.Application.Dto;
using Practica1.Projects.Application.Assembler;
using Practica1.Projects.Application.Dto;
using Practica1.Projects.Domain.Entity;
using Practica1.Projects.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practica1.Projects.Controllers
{
    [Route("v1/company/{companyId}/projects")]
    [ApiController]
    public class ProjectController : ControllerBase
    {

        private readonly IProjectRepository _projectRepository;
        private readonly ProjectCreateAssembler _projectCreateAssembler;

        public ProjectController(IProjectRepository projectRepository, ProjectCreateAssembler projectCreateAssembler)
        {
            _projectRepository = projectRepository;
            _projectCreateAssembler = projectCreateAssembler;
        }

        [HttpPost]
        public IActionResult Create(long companyId, [FromBody] ProjectCreateDto projectCreateDto)
        {
            projectCreateDto.CompanyId = companyId;
            Project project = _projectCreateAssembler.toEntity(projectCreateDto);
            _projectRepository.Create(project);
            return StatusCode(StatusCodes.Status201Created, new ApiStringResponseDto("Project Created!"));

        }
    }
}
