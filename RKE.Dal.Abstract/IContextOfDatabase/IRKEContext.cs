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

        IDbSet<Lesson> Lesson { get; set; }
        IDbSet<Teacher> Teacher { get; set; }
        IDbSet<ExternalStudentsGroup> ExternalStudentsGroup { get; set; }
        IDbSet<Group> Group { get; set; }
        IDbSet<Session> Session { get; set; }
        IDbSet<Week> Week { get; set; }
        IDbSet<LessonForExternalStudents> LessonForExternalStudents { get; set; }
        IDbSet<TEntity> Set<TEntity>() where TEntity : class;
        DbEntityEntry Entry(object entity);
        int SaveChanges();

        Task<int> SaveChangesAsync();
        Database Database { get; }
    }
}
