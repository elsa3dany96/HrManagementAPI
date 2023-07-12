using HrManagement.Core.IRepo;
using HrManagement.EF.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HrManagement.EF.Empliment
{
    public class MainRepo<T> : IMainRepo<T>where T : class
    {
        private readonly ApplicationDbContext _context;

        public MainRepo(ApplicationDbContext context) => _context = context;
        

     
        public async Task<T> CreateAync(T model)
        {
          var Result = await  _context.AddAsync(model);
            
            return model;
        }

        public async Task<bool> Delete(T model)
        {
           IQueryable<T> query = _context.Set<T>();
            var Find = query.FirstOrDefault(model);
            if (Find == null) return false;
            _context.Remove(Find);
            var Result = await _context.SaveChangesAsync();
            if (Result > 0) return true;
            return false;


        }

        public async Task<List<T>> GetListBy(System.Linq.Expressions.Expression<Func<T, bool>> match, params System.Linq.Expressions.Expression<Func<T,
            object>>[]? includes)
        {
            try
            {
                IQueryable<T> query = _context.Set<T>().Where(match);
                
                    if (includes != null)
                    {
                        foreach (var include in includes)
                        {
                            query = query.Include(include);
                        }
                    }
                    return await query.ToListAsync();
                
            }
            catch (Exception ex) 
            {
                
            }
            return default;





        }

        public async Task<T> GetOneBy(Expression<Func<T, bool>> match, params Expression<Func<T, object>>[]? includes)
        {
            try
            {
                IQueryable<T> query = _context.Set<T>().Where(match);
                if (includes != null)
                {
                    foreach (var include in includes)
                    {
                        query = query.Include(include);
                    }
                }
                return await query.FirstOrDefaultAsync();
            }
            catch(Exception ex) {}
            return default(T);
        }

        public async Task<T> FindThis(string id)
        {
            return await _context.Set<T>().FindAsync(id);
        }
    }
}
