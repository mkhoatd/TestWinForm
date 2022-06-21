using System;
using System.Data.Entity;
using System.Linq;

namespace TestWinForm.Models
{
    public class FoodsDbContext : DbContext
    {
        // Your context has been configured to use a 'ThucAn' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'TestWinForm.Models.ThucAn' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'ThucAn' 
        // connection string in the application configuration file.
        public FoodsDbContext()
            : base("name=Foods")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<MonAn> MonAns { get; set; }
        public virtual DbSet<NguyenLieu> NguyenLieus { get; set; }
        public virtual DbSet<MonAnNguyenLieu> MonAnNguyenLieus { get; set; }
    }
}