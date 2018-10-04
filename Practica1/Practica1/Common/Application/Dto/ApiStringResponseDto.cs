﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practica1.Common.Application.Dto
{
    public class ApiStringResponseDto
    {
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        public ApiStringResponseDto(string message)
        {
            Message = message;
        }
    }
}
