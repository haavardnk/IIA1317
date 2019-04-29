using System.Collections.Generic;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace VinylCrow
{
    public class Facade
    {
        private Database _db = new Database();
        public List<Record> GetRecordList()
        {
            var list = _db.GetRecordList(0);

            return list;
        }

        public void SaveRecord(Record record)
        {
            _db.SaveRecord(record);
        }

        public void NewRecord()
        {
            _db.CreateRecord();
        }

        public void DeleteRecord(Record record)
        {
            _db.DeleteRecord(record);
        }
    }
}