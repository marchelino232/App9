using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using SQLite;

namespace App9
{
    class Database
    {
        readonly SQLiteAsyncConnection _database;

        public Database(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<customer>().Wait();
        }
        public Task<List<customer>> GetCustomersAsync()
        {
            return _database.Table<customer>().ToListAsync();
        }

        public Task<int> SaveCustomerAsync(customer customer)
        {
            return _database.InsertAsync(customer);
        }
    }
    }