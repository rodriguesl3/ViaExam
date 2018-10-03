using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using ViaExam.Auth.Domain.Entities;

namespace ViaExam.Auth.EF.Context
{
    public class EfDbContext : DbContext
    {
        public EfDbContext(DbContextOptions<EfDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Authentication>().HasData(
                new Authentication {Id=1, Email = "kevinemanuelnascimento@chalu.com.br", Salt = "aQnJInrpgB", Sha1 = "1d431c83af53811c15d7cf2fd2b566daec4d2ca5" },
                new Authentication {Id=2, Email = "viniciusnelsonassuncao86@sectron.com.br", Salt = "x1KuqozHwk", Sha1 = "21a795d2fda4e628cec4842f7ccbc66820ddc923" },
                new Authentication {Id=3, Email = "rodrigooliveraraujo98@rafaelmarin.net", Salt = "62hwrh2dQ4", Sha1 = "32560cd41284a92446fbf013fd8b0fca1a90a66a" },
                new Authentication {Id=4, Email = "rraimundomarcosenzodarocha@igly.com.br", Salt = "9Gw3NN5jOo", Sha1 = "2b3511ddfb14b482c2beb5f9e99e32d9a1d7d9ff" },
                new Authentication {Id=5, Email = "caueandremonteiro84@sigtechbr.com", Salt = "f7yGnuAfoc", Sha1 = "37cef2b2573124b5d3dffc939c978b9ef0f7ce39" },
                new Authentication {Id=6, Email = "rodrigonelsonbarros78@ddfnet.com.br", Salt = "OhrPhUaWGA", Sha1 = "e2999fe11dd95256e9e7ba923ad2d5bacbe88550" },
                new Authentication {Id=7, Email = "kevinemanuelnascimento@defnet.com.br", Salt = "pIN9xFqCTl", Sha1 = "58d38ffd979e65f802603b0df9609198d1bb2298" });
            base.OnModelCreating(modelBuilder);
        }


        public DbSet<Authentication> Authentication { get; set; }
    }
}
