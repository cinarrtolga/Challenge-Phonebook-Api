using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Business.Abstract;
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
        private readonly IUsersService _usersService;

        public AuthenticationController(IConfiguration config, IUsersService usersService)
        {
            _config = config;
            _usersService = usersService;
        }

        [HttpPost]
        [Route("getToken")]
        public ActionResult GetToken(AuthenticationModel request)
        {
            if (!ModelState.IsValid)
                return Ok(new ServiceResponseModel { Success = false, Message = "Invalid request." });

            if (_usersService.CheckUser(request.Username, request.Password))
            {
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

                var tokenDetail = new TokenModel
                {
                    Token = new JwtSecurityTokenHandler().WriteToken(token),
                    ExpireDate = DateTime.Now.AddMinutes(180),
                    TokenType = "Bearer"
                };

                return Ok(new ServiceResponseModel { Success = true, Message = "Request successfully", Object = tokenDetail });
            }
            else
            {
                return Ok(new ServiceResponseModel { Success = false, Message = "Invalid User" });
            }
        }
    }
}
