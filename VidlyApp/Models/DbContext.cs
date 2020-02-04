using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace VidlyApp.Models

{

    public class VidlyContext : DbContext

    {

        public VidlyContext()

        {

        }

        //Entities

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Movie> Movies { get; set; }

    }

}