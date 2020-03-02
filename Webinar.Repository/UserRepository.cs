using Arch.EntityFrameworkCore.UnitOfWork;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Webinar.Models;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace Webinar.Repository
{

    public class UserRepository : Repository<tbUser>, IRepository<tbUser>
    {
        private RssDbContext db;
        private IConfiguration config;

        public UserRepository(RssDbContext dbContext, IConfiguration Configuration) : base(dbContext) 
        {
            db = dbContext; 
            config = Configuration;
        }

        private List<tbUser> _users = new List<tbUser>
        { 
            new tbUser { Id = 1, FirstName = "Test", LastName = "tbUser", Username = "test", Password = "test" } 
        };

        public viUser Authenticate(string username, string password)
        {
            viUser usr = new viUser();
            var res = _users.SingleOrDefault(x => x.Username == username && x.Password == password);

            if (res == null)  return null;

            var tokenHandler = new JwtSecurityTokenHandler();
            var SecretStr = config.GetSection("AppSettings:Secret").Value;
            var key = Encoding.ASCII.GetBytes(SecretStr);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[] 
                {
                    new Claim(ClaimTypes.Name, res.Id.ToString())
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            usr.Token = tokenHandler.WriteToken(token);
            usr.FirstName = res.FirstName;
            usr.LastName = res.LastName;
            usr.Username = res.Username;
            usr.Role = "jhjh";
            usr.Id = res.Id;

            return usr;
        }

        public IEnumerable<tbUser> GetAllUsers()
        {
            return _users.WithoutPasswords();
        }
    }
}
