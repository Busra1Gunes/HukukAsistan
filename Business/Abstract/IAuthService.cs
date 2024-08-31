﻿using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAuthService
    {
        public Task<UserLoginResponseDto> LoginUserAsync(UserLoginRequestDto userLoginRequestDto);
    }
}
