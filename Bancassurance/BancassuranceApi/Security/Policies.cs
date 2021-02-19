using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancassuranceApi.Security
{
    public class Policies
    {
        public const string User = "2";
        public const string Admin = "1";    
        public const string SuperAdmin = "3";

        public static AuthorizationPolicy AdminPolicy()
        {
            return SetupPolicy(Admin);
        }
        public static AuthorizationPolicy UserPolicy()
        {
            return SetupPolicy(User);
        }

        public static AuthorizationPolicy SuperAdminPolicy()
        {
            return SetupPolicy(SuperAdmin);
        }

        public static AuthorizationPolicy SetupPolicy(string userRoleCode)
        {
            return new AuthorizationPolicyBuilder()
                .RequireAuthenticatedUser()
                .RequireRole(userRoleCode).Build();
        }
    }
}
