using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CrudOperationWebAPI.Models
{
    public class CrudOperationWebAPIContext : DbContext
    {
        public CrudOperationWebAPIContext (DbContextOptions<CrudOperationWebAPIContext> options)
            : base(options)
        {
        }

        public DbSet<CrudOperationWebAPI.Models.User> User { get; set; }
    }
}
