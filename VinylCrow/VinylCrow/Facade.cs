using System.Collections.Generic;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace VinylCrow
{
    public class Facade
    {
        private Database db = new Database();
        public Facade()
        {
            var list = db.GetRecordList(0);

        }
    }
}