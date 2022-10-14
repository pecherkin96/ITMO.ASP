using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

public class SampleContext : DbContext
{
    public SampleContext() : base("StudentsDB")
    { }
    public DbSet<Studentstable> Studentstable { get; set; }
}
