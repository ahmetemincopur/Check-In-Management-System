using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace check_inOtomasyonu
{
    internal class VeriTabani
    {
        static SqlConnection SQLConnect;
        static SqlDataAdapter DA;
        static SqlCommand CMD;
        static DataSet DS;
        static SqlDataReader DR;

        public static string SQLCon = @"Data Source=DESKTOP-V8IBM9O\MSSQLSERVER01;Initial Catalog=check-inOtomasyonu;Integrated Security=True";

        public static bool BaglantiKontrol() 
        {
            using (SQLConnect = new SqlConnection(SQLCon)) 
            {
                try
                {
                    SQLConnect.Open();
                    return true;
                }
                catch (SqlException)
                {
                    //MessageBox.Show(exp.Message);
                    return false;
                }
            }
        }

        public static DataGridView DGV(DataGridView DGV,string SQLS) 
        {
            SQLConnect=new SqlConnection(SQLCon);
            DA = new SqlDataAdapter(SQLS, SQLCon);
            DS=new DataSet();
            SQLConnect.Open();
            DA.Fill(DS,SQLS);   
            
            DGV.DataSource=DS.Tables[SQLS];

            return DGV;
        }

      

    }
}
