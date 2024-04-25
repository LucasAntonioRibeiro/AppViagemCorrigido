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

        //public Task<List<pedagio>> Update(pedagio p)
        //{
        //    string sql = "Update pedagio set local=?, valor=? WHERE id=?";

        //    return _conn.QueryAsync<pedagio>(sql);
        //}
    }
}
