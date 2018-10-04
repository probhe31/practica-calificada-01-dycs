using AutoMapper;
using Practica1.Companies.Domain.Entity;
using Practica1.Users.Application.Dto;
using Practica1.Users.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practica1.Users.Application.Assembler
{
    public class UserCreateProfile : Profile
    {

        public UserCreateProfile()
        {
            CreateMap<UserCreateDto, User>()
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
