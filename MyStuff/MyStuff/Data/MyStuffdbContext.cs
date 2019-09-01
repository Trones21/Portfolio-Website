using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyStuff.Models;
using Microsoft.Extensions.Logging;


namespace MyStuff.Data
{
    /// <summary>
    /// For Webapp: Connection strings are stored in appsettings.json
    /// Choose connection string by modifying Startup.ConfigureServices
    /// </summary>
    public class MyStuffdbContext : DbContext
    {
        public DbSet<Book> FavoriteBooks { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public MyStuffdbContext(DbContextOptions<MyStuffdbContext> options) : base(options)
        {

        }

        /// <summary>
        /// Use this to prepare databases for running External Interfaces through Test Explorer (.Net core App won't be running, so the code in Startup.cs is irrelevant)
        /// And using Ef core
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                //GoDaddy 
                "Server=198.71.227.2; Initial Catalog = MyStuff; Persist Security Info = False; User ID=Trones; Password=C6aswlechi4dr; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = True; Connection Timeout = 30;"
                //Azure
                //"Server=tcp:trones21pkc6.database.windows.net, 1433; Initial Catalog = MyStuff; Persist Security Info = False; User ID=Trones; Password=C6aswlechi4dr; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;"
                //WorkLaptop
                //"Server = (localdb)\\MSSQLLocalDB; Database=MyStuff; Trusted_Connection = True;"
                //"Server = (localdb)\\ProjectsV13; Database=MyStuffV13; Trusted_Connection = True;"
                //PersonalLaptop
                //"Data Source=DESKTOP-TTI6PV9; Database=MyStuff; Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
                )
                ;
        }
    }
}


