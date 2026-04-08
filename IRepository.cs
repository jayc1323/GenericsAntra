using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsAntra
{   
    public class Entity
    {
               public int Id { get; set; }

    }
    internal interface IRepository<T> where T : Entity 
    {
        void Add(T item);
         void Remove(T item);
        void Save();
        IEnumerable<T> GetAll();
        T GetById(int id);
    }
    public class GenericRepository<T> : IRepository<T> where T : Entity
    {
        private List<T> items = new List<T>(); 


       public void Add(T item)
        {
            items.Add(item);
        }
        public void Remove(T item)
        {
                   items.Remove(item);
                
        }
        public void Save()
        {

        }
        public IEnumerable<T> GetAll()
        {
            return items.AsEnumerable();
        }
        public T GetById(int id)
        {
            return items.Find(x => x.Id == id);
           
            
        }
    }
}
