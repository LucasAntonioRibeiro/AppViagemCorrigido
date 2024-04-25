using AppSiteCorrigido.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSiteCorrigido.Helpers
{
    public class SQLiteDatabaseHelper
    {
        readonly SQLiteAsyncConnection _connection;

        public SQLiteDatabaseHelper (String path)
        {
            _connection = new SQLiteAsyncConnection (path);
            _connection.CreateTableAsync<pedagio>().Wait ();
        }

        public Task<int> Insert(pedagio p)
        {
            return _connection.InsertAsync(p);
        }

        public Task<int> Delete(int id)
        {
            return _connection.Table<pedagio>().DeleteAsync();
        }

        public Task<List<pedagio>> GetAll()
        {
            return _connection.Table<pedagio>().ToListAsync();
        }
        
    }
}
