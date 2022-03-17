using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CVMTest.Models
{
    public class Coffee
    {
        [Key]
        public int CofeeId { get; set; }

        public CofeeType CofeeType { get; set; }

        public CoffeeCharacteristics Characteristics { get; set; }

        public CoffeeDecoration CoffeeDecoratrion { get; set; }

    }
    public enum CofeeType
    {
        Latte,
        Macchiato,
        Espresso,
        Americano
    }
    public enum CoffeeCharacteristics
    {
        Empty,
        Sugar,
        Creamer,
        Caramelle,
        MoreMilk
    }
    public enum CoffeeDecoration
    {
        Empty,
        SingleDoseMilk,
        OnePackSugar,
    }
}

