using AutoMapper;
using Practica1.Companies.Application.Dto;
using Practica1.Companies.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practica1.Companies.Application.Assembler
{
    public class CompanyCreateAssembler
    {
        private readonly IMapper _mapper;

        public CompanyCreateAssembler(IMapper mapper)
        {
            _mapper = mapper;
        }

        public Company toEntity(CompanyCreateDto companyDto)
        {
            return _mapper.Map<Company>(companyDto);
        }
    }
}
