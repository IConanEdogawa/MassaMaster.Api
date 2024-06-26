﻿using MassaMaster.Domain.Entities.DTOs;
using MediatR;
using Microsoft.AspNetCore.Http;


namespace MassaMaster.Application.UseCases.NewsCases.Commands
{
    public class UpdateNewsCommand : IRequest<ResponseModel>
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public IFormFile CardPhoto { get; set; }
        public string Date { get; set; }
        public string Description { get; set; }
        public Guid? UserId { get; set; }
    }
}
