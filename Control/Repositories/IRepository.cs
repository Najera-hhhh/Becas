using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Collections.Generic;

namespace Control
{
    public interface IRepository<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll();
        T Get(Int64 id);
        int Insert(T entity);
        void Delete(T entity);
        void Update(T entity);
        DbSet<T> GetContex();
    }
}