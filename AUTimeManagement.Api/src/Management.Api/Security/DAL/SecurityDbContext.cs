using AUTimeManagement.Api.Management.Api.Security.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace AUTimeManagement.Api.Management.Api.Security.DAL;

public class SecurityDbContext : IdentityDbContext<ApplicationUser>
{
}

