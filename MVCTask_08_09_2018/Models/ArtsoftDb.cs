namespace MVCTask_08_09_2018.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ArtsoftDb : DbContext
    {
        // Your context has been configured to use a 'ArtsoftDb' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'MVCTask_08_09_2018.Models.ArtsoftDb' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'ArtsoftDb' 
        // connection string in the application configuration file.
        public ArtsoftDb()
            : base("name=ArtsoftDb")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }

        public virtual DbSet<ProgrammingLanguage> ProgrammingLanguages { get; set; }
        public virtual DbSet<Department> Departments{ get; set; }
        public virtual DbSet<Sex> Sexes { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}