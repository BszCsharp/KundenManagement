using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
namespace DataAccess
{
    public class DataTransfer
    {
        OleDbConnection con = null;

        internal bool OpenConnection()
        {
            bool result = true;
            if (con == null) con = new OleDbConnection(Settings1.Default.ConString);
            try
            {
                if(con.State != System.Data.ConnectionState.Open)
                con.Open();
            }
            catch (OleDbException  e)
            {

                result = false;
            }
            return result;
        }
        public List<Kunde> GetAlleKunden()
        {
            List<Kunde> lKu = new List<Kunde>();
            OpenConnection();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandText = "Select * from Kunden";
            try
            {
                OleDbDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    int i = 0;
                    try
                    {
                        Kunde k = new Kunde
                                  {
                                       KundenID = reader.GetString(i++),
                                       Name = reader.GetString(i++),
                                       VName = reader.GetString(i++),
                                       GebDat = reader.GetString(i++)
                                   };
                    }
                    catch (Exception)
                    {

                        liku = null;
                    }
                    lKu.Add(k);
                }
                return lKu;
            }
            catch (Exception)
            {

                return null;
            }

        }


        public bool SaveKunde(Kunde kunde)
        {
            Boolean result = true;
            if(OpenConnection() == false)
            {
                result = false;
            }
            else
            {
                OleDbCommand inscmd = con.CreateCommand();
                inscmd.Parameters.AddWithValue("ID", kunde.KundenID);
                inscmd.Parameters.AddWithValue("Name", kunde.Name);
                inscmd.Parameters.AddWithValue("VName", kunde.VName);
                inscmd.Parameters.AddWithValue("GebDat", kunde.GebDat);

                inscmd.CommandText= "Insert  Into Kunden Values(?,?,?,?)";
                inscmd.ExecuteNonQuery();

            }
                



            return result;

        }
    }
}
