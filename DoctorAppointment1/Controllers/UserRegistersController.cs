using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DoctorAppointment1.Models;

namespace DoctorAppointment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserRegistersController : ControllerBase
    {
        private readonly Doctor_83819DBContext _context;

        public UserRegistersController(Doctor_83819DBContext context)
        {
            _context = context;
        }

        // GET: api/UserRegisters
        [HttpGet]
        public IEnumerable<UserRegister> GetUserRegisters()
        {
            return _context.UserRegisters;
        }

        // GET: api/UserRegisters/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserRegister([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var userRegister = await _context.UserRegisters.FindAsync(id);

            if (userRegister == null)
            {
                return NotFound();
            }

            return Ok(userRegister);
        }

        // PUT: api/UserRegisters/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUserRegister([FromRoute] int id, [FromBody] UserRegister userRegister)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != userRegister.UserId)
            {
                return BadRequest();
            }

            _context.Entry(userRegister).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserRegisterExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/UserRegisters
        [HttpPost]
        public async Task<IActionResult> PostUserRegister([FromBody] UserRegister userRegister)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.UserRegisters.Add(userRegister);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUserRegister", new { id = userRegister.UserId }, userRegister);
        }

        // DELETE: api/UserRegisters/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUserRegister([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var userRegister = await _context.UserRegisters.FindAsync(id);
            if (userRegister == null)
            {
                return NotFound();
            }

            _context.UserRegisters.Remove(userRegister);
            await _context.SaveChangesAsync();

            return Ok(userRegister);
        }

        private bool UserRegisterExists(int id)
        {
            return _context.UserRegisters.Any(e => e.UserId == id);
        }
    }
}