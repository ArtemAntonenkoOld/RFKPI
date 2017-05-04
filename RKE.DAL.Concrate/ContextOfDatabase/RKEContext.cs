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
            : base("name=RKEDatabaseConnectionString")
        {
            Database.SetInitializer<RKEContext>(new CreateDatabaseIfNotExists<RKEContext>());
        }
        public virtual IDbSet<Aud> Auds { get; set; }
        public virtual IDbSet<Disziplin> Disziplins { get; set; }
        public virtual IDbSet<Group> Groups { get; set; }
        public virtual IDbSet<LessonChanged> LessonChangeds { get; set; }
        public virtual IDbSet<Lesson> Lessons { get; set; }
        public virtual IDbSet<Teacher> Teachers { get; set; }

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
            modelBuilder.Entity<IdentityUserLogin>().HasKey<string>(l => l.UserId);
            modelBuilder.Entity<IdentityRole>().HasKey<string>(r => r.Id);
            modelBuilder.Entity<IdentityUserRole>().HasKey(r => new { r.RoleId, r.UserId });
            modelBuilder.Entity<Aud>()
                .HasMany(e => e.LessonChangeds)
                .WithOptional(e => e.Auds)
                .HasForeignKey(e => e.AudApiId);

            
            modelBuilder.Entity<Aud>()
                .HasMany(e => e.Lessons)
                .WithOptional(e => e.Auds)
                .HasForeignKey(e => e.AudApiId);

            modelBuilder.Entity<Disziplin>()
                .HasMany(e => e.Lessons)
                .WithOptional(e => e.Disziplins)
                .HasForeignKey(e => e.DisziplinApiId);

           
            modelBuilder.Entity<Group>()
                .HasMany(e => e.Lessons)
                .WithMany(e => e.Groups)
                .Map(m => m.ToTable("LessonGroups").MapLeftKey("Group_ApiGroupId").MapRightKey("Lesson_Id"));

            modelBuilder.Entity<LessonChanged>()
                .HasMany(e => e.Lessons)
                .WithOptional(e => e.LessonChangeds)
                .HasForeignKey(e => e.LessonChangedId);

            modelBuilder.Entity<Teacher>()
                .HasMany(e => e.Lessons)
                .WithOptional(e => e.Teachers)
                .HasForeignKey(e => e.TeacherApiId);

        }
        
    }
}
