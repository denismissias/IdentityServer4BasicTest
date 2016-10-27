using IdentityModel;
using IdentityServer4;
using IdentityServer4.Services.InMemory;
using System.Collections;
using System.Collections.Generic;
using System.Security.Claims;

namespace WebApplication2
{
    public class Users
    {
        public static List<InMemoryUser> Get()
        {
            var users = new List<InMemoryUser>
        {
            new InMemoryUser{Subject = "818727", Username = "alice", Password = "alice",
                Claims = new Claim[]
                {
                    new Claim(JwtClaimTypes.Name, "Alice Smith"),
                    new Claim(JwtClaimTypes.GivenName, "Alice"),
                    new Claim(JwtClaimTypes.FamilyName, "Smith"),
                    new Claim(JwtClaimTypes.Email, "AliceSmith@email.com"),
                    new Claim(JwtClaimTypes.EmailVerified, "true", ClaimValueTypes.Boolean),
                    new Claim(JwtClaimTypes.Role, "Admin"),
                    new Claim(JwtClaimTypes.Role, "Geek"),
                    new Claim(JwtClaimTypes.WebSite, "http://alice.com"),
                    new Claim(JwtClaimTypes.Address, @"{ 'street_address': 'One Hacker Way', 'locality': 'Heidelberg', 'postal_code': 69118,'country': 'Germany' }")
                }
            }
        };

            return users;
        }
    }
}
