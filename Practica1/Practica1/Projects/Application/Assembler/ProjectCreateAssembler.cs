using AutoMapper;
using Practica1.Projects.Application.Dto;
using Practica1.Projects.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practica1.Projects.Application.Assembler
{
    public class ProjectCreateAssembler
    {
        private readonly IMapper _mapper;

        public ProjectCreateAssembler(IMapper mapper)
        {
            _mapper = mapper;
        }

        public Project toEntity(ProjectCreateDto projectDto)
        {
            return _mapper.Map<Project>(projectDto);
        }
    }
}
