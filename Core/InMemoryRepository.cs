using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction_practice_REFORGER.Core
{
    public class InMemoryRepository<T> : IRepository<T>
    {
        private readonly List<T> _items = new List<T>();
        public void Add(T item)
        {
            _items.Add(item);
        }
        public void Remove(T item)
        {
            _items.Remove(item);
        }
        public int GetAll()
        {
            return 0;
        }
    }
}
