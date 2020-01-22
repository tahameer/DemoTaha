using CRUDPractice.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CRUDPractice.DBContext
{
    public class ProjectDBContext :DbContext
    {
        public ProjectDBContext():base("ProjectDBContext")
        {

        }

        public DbSet<EmployeeModel> Employee { get; set; }

    }
}