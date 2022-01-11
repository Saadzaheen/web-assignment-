using Microsoft.EntityFrameworkCore;
using Saad_Zaheen135.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Saad_Zaheen135.DataDb
{
    public class StoreDb : DbContext
    {
        public StoreDb(DbContextOptions<StoreDb> options) : base(options)
        {

        }
        public DbSet<OrderModel> orders { get; set; }
    }
}
