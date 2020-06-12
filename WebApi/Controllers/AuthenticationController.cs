using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Model.DataTransferObjects;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthenticationController : ControllerBase
    {
        private readonly IConfiguration _config;
        public AuthenticationController(IConfiguration config)
        {
            _config = config;
        }

        [HttpPost]
        [Route("getToken")]
        public ActionResult GetToken(AuthenticationModel request)
        {
            if(!ModelState.IsValid)
                return Ok(new ServiceResponseModel { Success = false, Message = "Invalid request." });
                
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:SecretKey"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim(ClaimTypes.Name, request.Username),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            var token = new JwtSecurityToken(
                issuer: _config["Jwt:Issuer"],
                audience: _config["Jwt:Audience"],
                claims: claims,
                expires: DateTime.Now.AddMinutes(180),
                signingCredentials: credentials
            );

            var tokenDetail = new TokenModel {
                Token = new JwtSecurityTokenHandler().WriteToken(token),
                ExpireDate = DateTime.Now.AddMinutes(180),
                TokenType = "Bearer"
            };

            return Ok(new ServiceResponseModel { Success = true, Message = "Request successfully", Object = tokenDetail }); 
        }
    }
}
