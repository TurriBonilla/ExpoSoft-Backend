using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ExpoSoft.Infrastructure.WebApi.Security
{
    public class Token
    {
        private readonly byte[] SecretKey;

        public Token(string secretKey)
        {
            SecretKey = Encoding.ASCII.GetBytes(@secretKey);
        }

        public string Create(string @email)
        {
            var claims = new ClaimsIdentity();
            claims.AddClaim(new Claim(ClaimTypes.Email, @email));

            var tokenDescription = new SecurityTokenDescriptor()
            {
                Subject = claims,
                Expires = DateTime.UtcNow.AddHours(2),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(SecretKey), SecurityAlgorithms.HmacSha256Signature)
            };

            var tokenHandle = new JwtSecurityTokenHandler();
            var createdToken = tokenHandle.CreateToken(tokenDescription);
            
            return tokenHandle.WriteToken(createdToken);
        }
    }
}
