﻿using IdentityServer4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityServer4Test
{
    public class Config
    {
        public static IEnumerable<ApiResource> GetApiResource()
        {
            return new List<ApiResource>
            {
                new ApiResource("api1","My api")
            };
        }

        public static IEnumerable<Client> GetClients()
        {
            return new List<Client> {
                new Client{
                    ClientId="client",
                    AllowedGrantTypes=GrantTypes.ClientCredentials,
                    ClientSecrets={ new Secret("secret".Sha256())},
                    AllowedScopes={ "api1"}
                },
               
            };
        }
    }
}
