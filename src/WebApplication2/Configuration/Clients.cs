using IdentityServer4.Models;
using System.Collections;
using System.Collections.Generic;

namespace WebApplication2
{
    public class Clients
    {
        public static IEnumerable<Client> Get()
        {
            return new List<Client>
        {
            new Client
            {
                ClientName = "Resource owner Client",
                ClientId = "roclient",
                ClientSecrets = new List<Secret>
                {
                    new Secret("madeupsecret".Sha256())
                },

                AllowedGrantTypes = GrantTypes.ResourceOwnerPassword,

                AllowedScopes = new List<string>
                {
                    StandardScopes.OpenId.Name,
                    StandardScopes.Profile.Name,
                    "api1"
                }
            }
        };
        }
    }
}
