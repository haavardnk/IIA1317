using System.Collections.Generic;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace VinylCrow
{
    public class Facade
    {
        private Database db = new Database();
        public List<Record> GetRecordList()
        {
            var list = db.GetRecordList(0);

            return list;
        }
    }
}