using AutoMapper;
using Practica1.Common.Domain.ValueObject;
using Practica1.Companies.Domain.Entity;
using Practica1.Projects.Application.Dto;
using Practica1.Projects.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practica1.Projects.Application.Assembler
{
    public class ProjectCreateProfile : Profile
    {
        public ProjectCreateProfile()
        {
            CreateMap<ProjectCreateDto, Project>()
                .ForMember(
                    dest => dest.Budget,
                    opts => opts.MapFrom(
                        src => new Money(src.Budget, src.Currency)
                    )
                )
                .ForMember(
                    dest => dest.Company,
                    opts => opts.MapFrom(
                        src => new Company
                        {
                            Id = src.CompanyId
                        }
                    )
                ).ReverseMap();
        }
    }
}
