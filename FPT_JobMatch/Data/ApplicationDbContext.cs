using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FPT_JobMatch.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<FPT_JobMatch.Models.Employer> Employer { get; set; }
        public DbSet<FPT_JobMatch.Models.Job> Job { get; set; }
        public DbSet<FPT_JobMatch.Models.JobSeeker> JobSeeker { get; set; }
        public DbSet<FPT_JobMatch.Models.Application> Application { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //Seed data for User & Role 
            SeedUserRole(builder);

        }
        private void SeedUserRole(ModelBuilder builder)
        {
            // A) SETUP Identity User
            // 1.Create accounts
            var adminAccount = new IdentityUser
            {
                Id = "admin",
                UserName = "admin@gmail.com",
                NormalizedUserName = "ADMIN@GMAIL.COM",
                NormalizedEmail = "ADMIN@GMAIL.COM",
                EmailConfirmed = true

            };

            var employerAccount = new IdentityUser
            {
                Id = "employer",
                UserName = "employer@gmail.com",
                NormalizedUserName = "EMPLOYER@GMAIL.COM",
                NormalizedEmail = "EMPLOYER@GMAIL.COM",
                EmailConfirmed = true

            };

            var userAccount = new IdentityUser
            {
                Id = "user",
                UserName = "user@gmail.com",
                NormalizedUserName = "USER@GMAIL.COM",
                NormalizedEmail = "USER@GMAIL.COM",
                EmailConfirmed = true
            };

            //2. Declare hasher for password encryption
            var hasher = new PasswordHasher<IdentityUser>();

            //3. Setup password for accounts
            adminAccount.PasswordHash = hasher.HashPassword(adminAccount, "123456");
            employerAccount.PasswordHash = hasher.HashPassword(employerAccount, "123456");
            userAccount.PasswordHash = hasher.HashPassword(userAccount, "123456");

            //4. Add accounts to databases
            builder.Entity<IdentityUser>().HasData(adminAccount, employerAccount, userAccount);

            //B) Setup IndentityRole
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = "admin-role",
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                },

                new IdentityRole
                {
                    Id = "employer-role",
                    Name = "Employer",
                    NormalizedName = "EMPLOYER"
                },

                new IdentityRole
                {
                    Id = "user-role",
                    Name = "User",
                    NormalizedName = "USER"
                }
                );

            //C) Setup IdentityUserRole
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    UserId = "admin",
                    RoleId = "admin-role"
                },

                new IdentityUserRole<string>
                {
                    UserId = "employer",
                    RoleId = "employer-role"
                },
                new IdentityUserRole<string>
                {
                    UserId = "user",
                    RoleId = "user-role"
                }
             );
        }
    }
}
