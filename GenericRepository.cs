using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExercise
{
    public class GenericRepository<T> where T : Entity
    {
        public List<T> Database { get; set; }
        private int _currentId = 0;

        public void AddEntity(T entity)
        {
            _currentId = (Database.LastOrDefault()?.Id ?? 0) + 1;
            entity.Id = _currentId++;
            Database.Add(entity);
        }

        public void DeleteEntity(int id)
        {
          var entity = Database.FirstOrDefault(
              e => e.Id == id);    
            
            if (entity != null)
            {
                Database.Remove(entity);
            }
        }

        public void Update(T entity)
        {
            var index = Database.FindIndex(e => e.Id == entity.Id);
            Database[index] = entity;
        }
        public T GetById(int id)
        {
            return Database
                .FirstOrDefault(entity => entity.Id == id) ?? throw new ArgumentException($"Item with Id {id} does not excist ");
        }
    }
}
