using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace VinylCrow
{
    public class Database
    {
        public SqlConnection con = new SqlConnection(
            @"Data Source=DESKTOP-PNGCAGM\SQLEXPRESS;Initial Catalog=CollectionDatabase;Trusted_Connection=True");

        public List<Record> GetRecordList(int id)
        {
            var recordList = new List<Record>();

            string selectSql = "select * from Record where CollectionId = " + id.ToString();
            con.Open();
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
                    record.seenLive = Convert.ToBoolean(dr["SeenLive"]);
                    record.description = Convert.ToString(dr["Description"]);

                    var binaryData = dr["Image"];
                    record.image = (byte[])binaryData;

                    record.displayTitle = record.artist.Trim() + " - " + record.title.Trim();

                    recordList.Add(record);
                }
            }
            con.Close();
            return recordList;
        }

        public void SaveRecord(Record record)
        {
            var selectSql =
                "UPDATE Record SET " +
                "Title=@ti, " +
                "Artist=@ar, " +
                "Year=@ye, " +
                "Genre=@ge, " +
                "Color=@co, " +
                "DateAdded=@da, " +
                "Condition=@con, " +
                "PressingNumber=@pn, " +
                "Signed=@si, " +
                "Limited=@li, " +
                "SeenLive=@se, " +
                "Description=@de, " +
                "Image=@im " +
                "WHERE RecordId = @id";

            con.Open();
            var cmd = new SqlCommand(selectSql, con);

            cmd.Parameters.AddWithValue("@ti", record.title);
            cmd.Parameters.AddWithValue("@ar", record.artist);
            cmd.Parameters.AddWithValue("@ye", record.year);
            cmd.Parameters.AddWithValue("@ge", record.genre);
            cmd.Parameters.AddWithValue("@co", record.color);
            cmd.Parameters.AddWithValue("@da", record.dateAdded);
            cmd.Parameters.AddWithValue("@con", record.condition);
            cmd.Parameters.AddWithValue("@pn", record.pressingNumber);
            cmd.Parameters.AddWithValue("@si", record.signed);
            cmd.Parameters.AddWithValue("@li", record.limited);
            cmd.Parameters.AddWithValue("@se", record.seenLive);
            cmd.Parameters.AddWithValue("@de", record.description);
            cmd.Parameters.AddWithValue("@im", record.image);
            cmd.Parameters.AddWithValue("@id", record.recordId);

            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void CreateRecord()
        {
            var selectSql = "EXEC CreateRecord";

            con.Open();
            var cmd = new SqlCommand(selectSql, con);

            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}