using ASPNetCoreWithAngular.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCoreWithAngular.Data.Context
{
    public class ItemContext : DbContext
    {
        public ItemContext(DbContextOptions<ItemContext> options)
            : base(options) { }
        public ItemContext() { }
        public DbSet<ItemDetails> ItemDetails { get; set; }
    }
}
