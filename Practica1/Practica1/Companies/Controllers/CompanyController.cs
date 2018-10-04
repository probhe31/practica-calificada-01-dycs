using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Practica1.Common.Application.Dto;
using Practica1.Companies.Application.Assembler;
using Practica1.Companies.Application.Dto;
using Practica1.Companies.Domain.Entity;
using Practica1.Companies.Domain.Repository;

namespace Practica1.Companies.Controllers
{
    [Route("v1/company/{companyId}")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyRepository _companyRepository;
        private readonly CompanyCreateAssembler _companyCreateAssembler;

        public CompanyController(ICompanyRepository companyRepository, CompanyCreateAssembler companyCreateAssembler)
        {
            _companyRepository = companyRepository;
            _companyCreateAssembler = companyCreateAssembler;
        }

        [HttpPost]
        public IActionResult Create([FromBody] CompanyCreateDto companyCreateDto)
        {
            Company company = _companyCreateAssembler.toEntity(companyCreateDto);
            _companyRepository.Create(company);
            return StatusCode(StatusCodes.Status201Created, new ApiStringResponseDto("Company Created!"));
        }
    }
}
