using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompShop.Storage_Models_.Entity
{
    public class BuyerContext : DbContext
    {
        public BuyerContext(DbContextOptions<BuyerContext> options) : base(options)
        { }
        public DbSet<Buyer> Buyers { get; set; }
    }
}
