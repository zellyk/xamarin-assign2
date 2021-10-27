using SQLite;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
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

        public Task<List<T>> GetAsync() => _database.Table<T>().ToListAsync();

        public Task<int> SaveAsync(T t) => _database.InsertAsync(t);

        public Task<T> GetOneByPredicate(Expression<Func<T, bool>> predicate)
        {
            return _database.Table<T>()
                .Where(predicate)
                .FirstOrDefaultAsync();
        }
    }
}
