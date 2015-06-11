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
                    Kunde k = new Kunde
                    {
                        KundenID = reader.GetString(i++),
                        Name = reader.GetString(i++),
                        VName = reader.GetString(i++),
                        GebDat = reader.GetString(i++)
                    };
                    lKu.Add(k);
                }
                return lKu;
            }
            catch (Exception)
            {

                return null; ;
            }

        }


        public bool SaveKunde(Kunde kunde)
        {
            Boolean result = true;


        }
    }
}
