﻿using MassaMaster.Domain.Entities.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassaMaster.Application.UseCases.CategoryCases.Commands
{
    public class CreateCategoryCommand : IRequest<ResponseModel>
    {
        public string Name { get; set; }

    }
}
