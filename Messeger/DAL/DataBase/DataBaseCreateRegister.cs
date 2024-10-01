using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Messeger.DAL.DataBase;

public class DataBaseCreateRegister : DbContext
{
    public DataBaseCreateRegister()
    {
        Database.EnsureCreated();
    }

    public DbSet<DataBaseTableType> DataBaseTableType { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=DESKTOP-582CB1R;Database=DataBaseRegisterPerson;Trusted_Connection=True;TrustServerCertificate=True;");
    }
}
