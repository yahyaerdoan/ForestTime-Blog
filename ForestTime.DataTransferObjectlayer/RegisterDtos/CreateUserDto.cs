﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForestTime.DataTransferObjectlayer.RegisterDtos
{
    public record CreateUserDto(string FirstName, string LastName, string UserName, string Email, string Password);
}
