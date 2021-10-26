using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Assign2
{
    public class GenericDBEntity<T> where T : class, new()
    {
        readonly SQLiteAsyncConnection _database;
        public GenericDBEntity(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<T>().Wait();
        }

        public Task<List<T>> GetAsync()
        {
            return
            _database.Table<T>().ToListAsync();
        }

        public Task<int> SaveAsync(T t)
        {
            return _database.InsertAsync(t);
        }
    }
}
