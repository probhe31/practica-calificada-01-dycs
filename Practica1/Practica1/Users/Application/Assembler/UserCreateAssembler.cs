using AutoMapper;
using Practica1.Users.Application.Dto;
using Practica1.Users.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practica1.Users.Application.Assembler
{
    public class UserCreateAssembler
    {
        private readonly IMapper _mapper;

        public UserCreateAssembler(IMapper mapper)
        {
            _mapper = mapper;
        }

        public User toEntity(UserCreateDto userCreateDto)
        {
            return _mapper.Map<User>(userCreateDto);
        }
    }
}
