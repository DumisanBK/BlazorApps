using BancassuranceApi.Utils;
using BancassuranceApi.ViewModels;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BancassuranceApi.Security
{
    public class TokenGenerator : ITokenGenerator
    {
        private readonly IConfiguration _config;

        public TokenGenerator(IConfiguration config)
        {
            _config = config;
        }

        public string Generate(SessionBridgeVm sessionBridge)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config.GetSection("Jwt:SecretKey").Get<string>()));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, sessionBridge.Username),
                new Claim(_config.GetSection("Jwt:FullNameKey").Get<string>(), sessionBridge.FullName),
                new Claim(_config.GetSection("Jwt:RoleIdKey").Get<string>(), Convert.ToString(sessionBridge.RoleId)),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            };

            var token = new JwtSecurityToken(
                issuer: _config.GetSection("Jwt:Issuer").Get<string>(),
                audience: _config.GetSection("Jwt:Audience").Get<string>(),
                claims: claims,
                expires: DateTime.Now.AddMinutes(Convert.ToDouble(_config.GetSection("Jwt:Minutes").Get<double>())),
                signingCredentials: credentials
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
