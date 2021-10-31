using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    public class UsersController : BaseController
    {
        private readonly DataContext _context;

        public UsersController(DataContext context)
        {
            // Dependency injection on the ctor.
            // DB is accessible via _context.
            _context = context;
        }

        /// <summary>
        /// End point to get all the users.
        /// We can also use List as the return type, but List is huge and has many
        /// unused functions inside.
        /// </summary>
        /// <returns>List of users.</returns>
        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
            return await _context.Users.ToListAsync();
        }

        /// <summary>
        /// End point to get specific user with his/her id.
        /// Accessible via api/users/1.
        /// </summary>
        /// <param name="id">Specified user's id</param>
        /// <returns>Specified user.</returns>
        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<AppUser>> GetUser(int id)
        {
            return await _context.Users.FindAsync(id);
        }
    }
}
