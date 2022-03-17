using CVMTest.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CVMTest.Context
{
    public class CoffeeDbContext : DbContext
    {
        //public CoffeeDbContext()
        //   : base()
        //{
        //}
        public CoffeeDbContext(DbContextOptions<CoffeeDbContext> options) : base(options)
        { }
        public DbSet<Coffee> Coffies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Coffee>().HasData(
                new Coffee
                {
                    CofeeId = 1,
                    CofeeType = CofeeType.Latte,
                    Characteristics = CoffeeCharacteristics.Caramelle,
                    CoffeeDecoratrion = CoffeeDecoration.SingleDoseMilk
                },
                 new Coffee
                 {
                     CofeeId = 2,
                     CofeeType = CofeeType.Espresso,
                     Characteristics = CoffeeCharacteristics.Creamer,
                     CoffeeDecoratrion = CoffeeDecoration.SingleDoseMilk
                 },
                 new Coffee
                 {
                     CofeeId = 3,
                     CofeeType = CofeeType.Macchiato,
                     Characteristics = CoffeeCharacteristics.Sugar,
                     CoffeeDecoratrion = CoffeeDecoration.SingleDoseMilk
                 }
                );
        }

    }
}
