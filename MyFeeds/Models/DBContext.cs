using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MyFeeds.Models
{
    public class DBContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public DBContext() : base("name=DBContext")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<DBContext>());
        }

        public DbSet<Feed> Feeds { get; set; }

        public System.Data.Entity.DbSet<MyFeeds.Models.Source> Sources { get; set; }

        public System.Data.Entity.DbSet<MyFeeds.Models.ContentType> ContentTypes { get; set; }

        public System.Data.Entity.DbSet<MyFeeds.Models.Content> Contents { get; set; }
    }
}
