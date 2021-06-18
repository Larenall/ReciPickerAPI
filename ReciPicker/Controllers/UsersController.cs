using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReciPicker.Models;
using ReciPicker.DTO;
using ReciPicker.Helper;
using Microsoft.AspNetCore.Authorization;
using System.Security.Cryptography;
using System.Text;
using ReciPicker.Controllers.Helper;

namespace ReciPicker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class UsersController : ControllerBase
    {
        private readonly recipickerContext db;
        private readonly IJwtAuthenticationManager JwtAuthentiocationManager;
        private readonly UserService userService;

        public UsersController(recipickerContext context, IJwtAuthenticationManager JwtAuthentiocationManager, UserService userService)
        {
            db = context;
            this.JwtAuthentiocationManager = JwtAuthentiocationManager;
            this.userService = userService;

        }

        [HttpGet]
        public List<UserCred> GetAllUsers()
        {
            List<UserCred> result = new List<UserCred>();
            db.Users.ToList().ForEach(el => result.Add(new UserCred(el.UserId, el.Login, el.Role)));
            return result;
        }
        [HttpPost]
        public SendRegisterUser Register(GetRegisterUser user)
        {
            bool loginTaken = db.Users.Any(u => u.Login == user.Login);
            bool emailTaken = db.Users.Any(u => u.Email == user.Email);
            if (!loginTaken && !emailTaken)
            {
                (string salted, string salt) = userService.SaltPassword(user.Password);
                db.Add(new User(user.Login, user.Email, salted, salt));
                db.SaveChanges();
            }
            var newUser = db.Users.FirstOrDefault(u => u.Email == user.Email);
            return new SendRegisterUser(newUser.UserId, newUser.Login, loginTaken, emailTaken, "user", new List<int>());
        }


        [HttpPut]
        public SendSignInUser Login(GetSignInUser _user)
        {
            User user = db.Users.FirstOrDefault(u => u.Login == _user.LoginOrEmail || u.Email == _user.LoginOrEmail);
            if (user == null)
            {
                return new SendSignInUser(false, false);
            }
            if (!userService.ComparePassword(_user.Password, user.Salt, user.Password))
            {
                return new SendSignInUser(true, false);
            }

            List<int> userFavourite = new List<int>();
            db.UserFavouriteRecipes.ToList().Where(el => el.UserId == user.UserId).ToList().ForEach(el => userFavourite.Add(el.RecipeId));

            return new SendSignInUser(user.UserId, user.Login, true, true, user.Role, userFavourite);
        }
        [HttpPatch("pass")]
        public bool ChangePassword(UserChangePassDTO _user)
        {
            User user = db.Users.FirstOrDefault(u => u.Login == _user.Login && u.Email == _user.Email);
            if (user != null)
            {
                user.Password = userService.SaltPasswordWithSalt(_user.Password, user.Salt);
                db.Update(user);
                db.SaveChanges();
                return true;
            }
            return false;
        }
        [HttpPatch("role")]
        public void ChangeRole(UserChangeRoleDTO _user)
        {
            User user = db.Users.FirstOrDefault(u => u.UserId == _user.UserId);
            user.Role = _user.Role;
            db.Update(user);
            db.SaveChanges();
        }
        [HttpPost("authenticate")]
        public IActionResult Authenticate([FromBody] UserCred user)
        {
            List<User> list = db.Users.ToList();
            var token = JwtAuthentiocationManager.Authenticate(user, list);
            if (token == null)
                return Unauthorized();
            return Ok(token);
        }

    }
}
