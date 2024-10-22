﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Data.Entity.Seeders
{
    public static class PeopleSeedData
    {
        public static void SeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PeopleModel>().HasData(
                new PeopleModel { Id = 1, Name = "Luis", LastName = "Lopez", Address = "123 Elm St" },
                new PeopleModel { Id = 2, Name = "Jeampierre", LastName = "Muñoz", Address = "431 Elm St" },
                new PeopleModel { Id = 3, Name = "Jean", LastName = "benedicto", Address = "233 Elm St" },
                new PeopleModel { Id = 4, Name = "Fabrizzio", LastName = "Zambrano", Address = "432 Elm St" },
                new PeopleModel { Id = 5, Name = "Fabian", LastName = "Ambrosio", Address = "32 Elm St" }
            );
        }
    }
}
