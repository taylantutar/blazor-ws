﻿using BookReservation.Data.Entities;
using BookReservation.Server.Services.Abstract;
using BookReservation.Shared.Dtos;
using BookReservation.Shared.Dtos.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

namespace BookReservation.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var users = await _userService.GetAll<UserGetAllResponseDto>();
            return Ok(new GResponse<List<UserGetAllResponseDto>>("Success", users));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var user = await _userService.GetSingle<UserGetByIdResponseDto>(id);

            if (user == null)
                return NotFound("User not found");
            else
                return Ok(new GResponse<UserGetByIdResponseDto>("Success", user));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var isSuccess = await _userService.Delete(id);

            if (!isSuccess)
                return NotFound(new GResponse<bool>("User not found"));
            else
                return Ok(new GResponse<bool>("User deleted", true));
        }

        [HttpPost]
        public async Task<IActionResult> Create(UserSaveRequestDto user)
        {
            try
            {
                var savedUser = await _userService.Create<UserSaveRequestDto, UserSaveResponseDto>(user);
                return Ok(new GResponse<UserSaveResponseDto>("Save is successful", savedUser));
            }
            catch (Exception ex)
            {
                return BadRequest(new GResponse<UserSaveResponseDto>("Error"));
            }
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("/api/[controller]/login")]
        public async Task<IActionResult> Login(UserLoginRequestDto userLoginDto)
        {
            var serviceResult = await _userService.Login(userLoginDto);
            return serviceResult.IsSucces ? Ok(serviceResult) : BadRequest(serviceResult);
        }


    }
}
