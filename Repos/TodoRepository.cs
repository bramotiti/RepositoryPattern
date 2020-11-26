using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RepositoryPattern.Data;
using RepositoryPattern.Models;
using RepositoryPattern.Repos.IRepos;

namespace RepositoryPattern.Repos
{
    public class TodoRepository : IGenericRepository
    {
        protected readonly ApplicationDbContext _context;
        public TodoRepository(ApplicationDbContext context) 
        {
            _context = context;
        }

        public void Add(Todo entity)
        {
            _context.Set<Todo>().Add(entity);
        }

        public IEnumerable<Todo> GetAll()
        {
            return _context.Set<Todo>().ToList();
        }

        public Todo GetById(int id)
        {
            return _context.Set<Todo>().Find(id);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
