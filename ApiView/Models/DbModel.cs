using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiView.Models;

namespace ApiView.Models
{
    public class DbModel:DbContext
    {
        public DbModel(DbContextOptions<DbModel> options) : base(options)
        {
            
        }
        public DbSet<Api> apies { get; set; }
        
    }
}
