using RKE.IOC.Common.Attributes;
using RKE.DAL.Abstract.IContextOfDatabase;
using RKE.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;

namespace RKE.DAL.Concrate.ContextOfDatabase
{
    [RequestScope]
    [BindsTo(typeof(IRKEContext))]
    public class RKEContext : IdentityDbContext<User>, IRKEContext
    {

        public RKEContext()
            : base("name=RKEDatabaseConnectionString") { 
            Database.SetInitializer<RKEContext>(new CreateDatabaseIfNotExists<RKEContext>());
            
        }

        public IDbSet<Lesson> Lesson { get; set; }
        public IDbSet<Teacher> Teacher { get; set; }
        public IDbSet<LessonChanged> LessonChanged { get; set; }
        public IDbSet<Group> Group { get; set; }
        public IDbSet<Session> Session  { get; set; }
        public IDbSet<Week> Week { get; set; }

        public IDbSet<LessonForExternalStudents> LessonForExternalStudents { get; set; }


        public IDbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return base.Set<TEntity>();
        }
        public static RKEContext Create()
        {
            return new RKEContext();
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
        //    modelBuilder.Types().Configure(entity => entity.ToTable("tb" + entity.ClrType.Name));

        }


    }
}
