using RKE.DAL.Abstract.IContextOfDatabase;
using RKE.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RKE.DAL.Concrate.ContextOfDatabase
{
    
    public class RKEContext : DbContext, IDataContext
    {

        public RKEContext()
            : base("name=RKEDatabaseConnectionString")
        {
        }

        public IDbSet<Lesson> Lesson { get; set; }
        public IDbSet<Teacher> Teacher { get; set; }
        public IDbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return base.Set<TEntity>();
        }
        public DbEntityEntry Entry(object entity)
        {
            return base.Entry(entity);
        }

        void IDisposable.Dispose()
        {
            base.Dispose();
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }


    }
}
