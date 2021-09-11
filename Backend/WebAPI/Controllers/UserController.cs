using AutoMapper;
using Core.Entities;
using Core.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.DTOs;
using WebAPI.Validators;

namespace WebAPI.Controllers
{
    [EnableCors("CustomPolicy")]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController:ControllerBase
    {
        private readonly IUserService _userService;
        private readonly INoteService _noteService;
        private readonly IMapper _mapper;

        public UserController(IUserService userService, INoteService noteService, IMapper mapper)
        {
            _userService = userService;
            _noteService = noteService;
            _mapper = mapper;
        }

        [HttpGet("")]
        public async Task<ActionResult<IEnumerable<UserDTO>>> GetAllUsers()
        {
            var users = await _userService.GetAll();
            var userResources = _mapper.Map<IEnumerable<User>, IEnumerable<UserDTO>>(users);
            return Ok(userResources);
        }

        [HttpGet("getbyid/{id}")]
        public async Task<ActionResult<UserDTO>> GetUserById(int id)
        {
            var user = await _userService.GetById(id);
            var userResource = _mapper.Map<User, UserDTO>(user);
            return Ok(userResource);
        }
        [HttpGet("getbyemail/{email}")]
        public async Task<ActionResult<UserDTO>> GetUserByEmail(string email)
        {
            var user = await _userService.GetByEmail(email);
            var userResource = _mapper.Map<User, UserDTO>(user);
            return Ok(userResource);
        }

        [HttpGet("getbynote/{noteId}")]
        public async Task<ActionResult<IEnumerable<UserDTO>>> GetUsersByNote(int noteId)
        {
            var note = await _noteService.GetById(noteId);
            var users = note.Users;
            var userResources = _mapper.Map<IEnumerable<User>, IEnumerable<UserDTO>>(users);
            return Ok(userResources);
        }

        [HttpPost("")]
        public async Task<ActionResult<UserDTO>> CreateUser([FromBody] SaveUserDTO saveUserResource)
        {
            var validator = new SaveUserResourceValidator();
            var validationResult = await validator.ValidateAsync(saveUserResource);

            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult.Errors);
            }

            var userToCreate = _mapper.Map<SaveUserDTO, User>(saveUserResource);
            var newUser = await _userService.Create(userToCreate);

            var user = await _userService.GetById(newUser.Id);
            var userResource = _mapper.Map<User, UserDTO>(user);

            return Ok(userResource);

        }

        [HttpPut("")]
        public async Task<ActionResult<UserDTO>> UpdateUser(int id, [FromBody] SaveUserDTO saveUserResource)
        {
            var validator = new SaveUserResourceValidator();
            var validationResult = await validator.ValidateAsync(saveUserResource);

            if (id == 0 || !validationResult.IsValid)
                return BadRequest(validationResult.Errors);

            var userToUpdate = await _userService.GetById(id);
            if (userToUpdate == null)
                return NotFound();

            var user = _mapper.Map<SaveUserDTO, User>(saveUserResource);
            await _userService.Update(userToUpdate, user);
            var updatedUser = await _userService.GetById(id);
            var updatedUserResource = _mapper.Map<User, UserDTO>(updatedUser);

            return Ok(updatedUserResource);
        }

        [HttpDelete("")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            if (id == 0) return BadRequest();

            var user = await _userService.GetById(id);
            if (user == null) return NotFound();

            await _userService.Delete(user);
            return NoContent();
        }
    }
}
