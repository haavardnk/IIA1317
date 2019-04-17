using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace VinylCrow
{
    public class Database
    {
        public SqlConnection con = new SqlConnection(
            @"Data Source=DESKTOP-PNGCAGM\SQLEXPRESS;Initial Catalog=CollectionDatabase;Trusted_Connection=True");

        public Database()
        {
            con.Open();
        }

        public List<Record> GetRecordList(int id)
        {
            var recordList = new List<Record>();

            string selectSql = "select * from Record where CollectionId = " + id.ToString();

            var cmd = new SqlCommand(selectSql, con);

            var dr = cmd.ExecuteReader();

            if (dr != null)
            {
                while (dr.Read())
                {
                    var record = new Record();

                    record.recordId = Convert.ToInt32(dr["RecordId"]);
                    record.title = Convert.ToString(dr["Title"]);
                    record.artist = Convert.ToString(dr["Artist"]);
                    record.year = Convert.ToDateTime(dr["Year"]);
                    record.genre = Convert.ToString(dr["Genre"]);
                    record.color = Convert.ToString(dr["Color"]);
                    record.dateAdded = Convert.ToDateTime(dr["DateAdded"]);
                    record.condition = Convert.ToString(dr["Condition"]);
                    record.pressingNumber = Convert.ToString(dr["PressingNumber"]);
                    record.signed = Convert.ToBoolean(dr["Signed"]);
                    record.limited = Convert.ToBoolean(dr["Limited"]);
                    record.limited = Convert.ToBoolean(dr["Limited"]);
                    record.description = Convert.ToString(dr["Description"]);

                    record.displayTitle = record.artist.Trim() + " - " + record.title.Trim();

                    recordList.Add(record);
                }
            }
            return recordList;
        }
    }
}