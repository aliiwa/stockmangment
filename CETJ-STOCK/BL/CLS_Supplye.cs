using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CETJ_STOCK.BL
{
    class CLS_Supplye
    {
       



        // اجراء جلب كل اذونات الاستلام
        public DataTable CET_ALL_SUPPLYE()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("CET_ALL_SUPPLYE", null);
            DAL.close();
            return Dt;
        }

        // اجراء لجلب كافة عناصر الموردين
        public DataTable GET_ALL_SUPPLYER()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_ALL_SUPPLYER", null);
            DAL.close();
            return Dt;
        }

        // اجراء التاكد من رقم اذن الاستلام
        public DataTable VerifySupplye(string supplye_code)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@supplye_code", SqlDbType.NVarChar, 50);
            param[0].Value = supplye_code;

            Dt = DAL.SelectData("VerifySupplye", param);

            DAL.close();
            return Dt;
        }

      
        // اجراء لاضافة البيانات لقاعدة البيانات
        public void ADD_SUPPLYE(string supplye_code, DateTime supplye_date, int supplyer_id,int invoice_number)

        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@supplye_code", SqlDbType.NVarChar, 50);
            param[0].Value = supplye_code;

            param[1] = new SqlParameter("@supplye_date", SqlDbType.DateTime);
            param[1].Value = supplye_date;

            param[2] = new SqlParameter("@supplyer_id", SqlDbType.Int);
            param[2].Value = supplyer_id;

            param[3] = new SqlParameter("@invoice_number", SqlDbType.Int);
            param[3].Value = invoice_number;

            DAL.ExcuteCommand("ADD_SUPPLYE", param);
            DAL.close();

        }

        public void ADD_SUPPLYE_DETAILS(string pro_code, string pro_name, string pro_unit, int pro_quantity, string spend_code)

        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@pro_code", SqlDbType.NVarChar, 50);
            param[0].Value = pro_code;

            param[1] = new SqlParameter("@pro_name", SqlDbType.NVarChar, 50);
            param[1].Value = pro_name;

            param[2] = new SqlParameter("@pro_unit", SqlDbType.NVarChar, 50);
            param[2].Value = pro_unit;

            param[3] = new SqlParameter("@pro_quantity", SqlDbType.Int);
            param[3].Value = pro_quantity;

            param[4] = new SqlParameter("@spend_code", SqlDbType.NVarChar, 50);
            param[4].Value = spend_code;



            DAL.ExcuteCommand("ADD_SUPPLYE_DETAILS", param);
            DAL.close();

        }

    }
}
