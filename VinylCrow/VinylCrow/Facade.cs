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

        public void SaveRecord(Record record)
        {
            db.SaveRecord(record);
        }

        public void NewRecord()
        {
            db.CreateRecord();
        }

        public void DeleteRecord(Record record)
        {
            db.DeleteRecord(record);
        }
    }
}