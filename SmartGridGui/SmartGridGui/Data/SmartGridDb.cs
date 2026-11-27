using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FreeSql;

namespace SmartGridEngine.Data
{
    public static class SmartGridDb
    {
        private static IFreeSql _fsql;

        public static IFreeSql Instance
        {
            get
            {
                if (_fsql == null)
                {
                    _fsql = new FreeSqlBuilder()
                        .UseConnectionString(DataType.Sqlite, @"Data Source=smartgrid.db")
                        .UseAutoSyncStructure(true)   // creates the tables automatically
                        .Build();
                    _fsql.CodeFirst.SyncStructure<PowerSourceRecord>();
                    _fsql.CodeFirst.SyncStructure<ReadingLog>();
                }
                return _fsql;
            }
        }
    }
}