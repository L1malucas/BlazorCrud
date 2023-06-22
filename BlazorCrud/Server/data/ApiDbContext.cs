using Microsoft.EntityFrameworkCore;

namespace BlazorCrud.Server.Data;

public class ApiDbContext : DbContext 
{
    public ApiDbContext (DbContextOptions<ApiDbContext> options) : base(options)  
    {

    }
}	