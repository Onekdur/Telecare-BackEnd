﻿using Asp.Versioning;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Telecare.Application.DTOs;
using Telecare.Application.Features.Account.Users.Command.Register;

namespace Telecare.Presentation.Controllers
{
    [ApiVersion("1.0")]
    [ApiController]
    [Route("api/{version}/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ISender sender;

        public UserController(ISender sender)
        {
            this.sender = sender;
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody] MemberDTO member, CancellationToken cancellationToken)
        {
            throw new Exception("hi");
            await sender.Send(new RegisterUserCommand(member));

            return Ok("Registarion Successfull");
        }
    }
}