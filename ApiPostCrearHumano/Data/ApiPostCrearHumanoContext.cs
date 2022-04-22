using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ApiPostCrearHumano.Model;

namespace ApiPostCrearHumano.Data
{
    public class ApiPostCrearHumanoContext : DbContext
    {
        public ApiPostCrearHumanoContext (DbContextOptions<ApiPostCrearHumanoContext> options)
            : base(options)
        {
        }

        public DbSet<ApiPostCrearHumano.Model.Humano> Humano { get; set; }
    }
}
