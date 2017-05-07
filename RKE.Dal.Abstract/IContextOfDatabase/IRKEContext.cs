using RKE.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RKE.DAL.Abstract.IContextOfDatabase
{
    public interface IRKEContext : IDisposable
    {
        IDbSet<Aud> Auds { get; set; }
        IDbSet<Disziplin> Disziplins { get; set; }
        IDbSet<Group> Groups { get; set; }
        IDbSet<Lesson> Lessons { get; set; }
       // IDbSet<LessonChanged> LessonChangeds { get; set; }
        IDbSet<Teacher> Teachers { get; set; }
        IDbSet<LessonGroups> LessonGroups { get; set; }
        
        IDbSet<TEntity> Set<TEntity>() where TEntity : class;
        DbEntityEntry Entry(object entity);
        int SaveChanges();

        Task<int> SaveChangesAsync();
        Database Database { get; }
    }
}
