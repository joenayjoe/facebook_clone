﻿using AutoMapper;
using fb_clone.DTO;
using fb_clone.Exceptions;
using fb_clone.Interfaces;
using fb_clone.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Threading.Tasks;

namespace fb_clone.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IRepositoryManager repository;
        private readonly IMapper mapper;

        public UsersController(IRepositoryManager repo, IMapper mapper)
        {
            this.repository = repo;
            this.mapper = mapper;
        }

        [HttpGet]
        [Route("current_user")]
        [Authorize]
        public async Task<IActionResult> GetCurrentUser()
        {
            var user = await repository.Users.GetUserByEmailAsync(User.FindFirstValue(ClaimTypes.Email));
            if (user == null)
            {
                throw new UnauthorizeException("We cannot authenticate you. Login again");
            }
            var result = mapper.Map<UserDTO>(user);
            return Ok(result);
        }
    }
}
