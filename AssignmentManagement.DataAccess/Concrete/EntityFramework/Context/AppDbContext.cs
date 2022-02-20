using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssignmentManagement.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace AssignmentManagement.DataAccess.Concrete.EntityFramework.Context
{
    public class AppDbContext: Microsoft.EntityFrameworkCore.DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Assignments> Assignments { get; set; }
        public DbSet<Student_Assignments> Student_Assignment { get; set; }
        public DbSet<Student_Classes> Student_Class { get; set; }
        public DbSet<Students> Students { get; set; }
        public DbSet<Teachers> Teachers { get; set; }
    }
}
