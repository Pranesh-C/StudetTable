﻿using DataAccessLayer.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
    }
}

       
