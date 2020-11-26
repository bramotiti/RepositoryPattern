using RepositoryPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPattern.Repos.IRepos
{
    public interface IGenericRepository
    {
        Todo GetById(int id);
        IEnumerable<Todo> GetAll();
        public void Add(Todo entity);
        public void Save();
    }
}
