using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShauryaTechTest.Database;
using ShauryaTechTest.Database.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ShauryaTechTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        // GET: api/<UserController>
        [HttpGet]
        public List<User> Get()
        {
            return stt_dbContext._dbContext.Users.ToList();
        }

        // POST api/<UserController>
        [HttpPost]
        public IActionResult Post([FromBody] User user)
        {
            try
            {
                stt_dbContext._dbContext.Users.Add(user);
                stt_dbContext._dbContext.SaveChanges();

                return StatusCode(StatusCodes.Status201Created, "Added Successfullly");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status417ExpectationFailed, ex);
            }
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] byte[] image)
        {
            try
            {
                User user = stt_dbContext._dbContext.Users.Where(s => s.UserID == id).FirstOrDefault();

                string imagePath = "D:/ProfilePictures/" + id + ".png";
                System.IO.File.WriteAllBytes(imagePath, image);
                user.Photopath = imagePath;
                stt_dbContext._dbContext.SaveChanges();
                return StatusCode(StatusCodes.Status202Accepted, "Updated Successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status417ExpectationFailed, ex);
            }
        }
    }
}
