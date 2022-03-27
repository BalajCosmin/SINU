using Microsoft.EntityFrameworkCore;
using SINU.UserModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SINU.Data.UserContext
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options) { 
        
        }

        public DbSet<User> Users { set; get; }

        protected override void OnModelCreating(ModelBuilder modelBuilder){

            modelBuilder.Entity<User>(entity =>
            {
             entity.HasIndex(e => e.IDNP).IsUnique();


            });



            
            }
    }
}
