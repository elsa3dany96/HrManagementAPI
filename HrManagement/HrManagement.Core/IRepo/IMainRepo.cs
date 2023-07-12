using HrManagement.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HrManagement.Core.IRepo
{
    public interface IMainRepo<T>where T : class
    {
        Task<T> CreateAync(T model);
        Task<bool> Delete(T model);
        Task<T> FindThis(string id);
        Task<T> GetOneBy(Expression<Func<T,bool>> match, params Expression<Func<T, object>>[]? includes);
        Task<List<T>> GetListBy(Expression<Func<T,bool>> match, params Expression<Func<T, object>>[]? includes);
    }
}
