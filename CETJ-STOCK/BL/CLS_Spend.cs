using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CETJ_STOCK.BL
{
    class CLS_Spend
    {
        // اجراء جلب كل اذونات الصرف
        public DataTable GET_ALL_SPEND()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_ALL_SPEND", null);
            DAL.close();
            return Dt;
        }

        // اجراء لجلب كافة عناصر الاقسام
        public DataTable GET_ALL_DEPARTMNT()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_ALL_DEPARTMNT", null);
            DAL.close();
            return Dt;
        }

        // اجراء التاكد من رقم اذن الصرف
        public DataTable VerifySpend(string spend_code)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
           
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@spend_code", SqlDbType.NVarChar, 50);
            param[0].Value = spend_code;

            Dt = DAL.SelectData("VerifySpend", param);

            DAL.close();
            return Dt;
        }

        // اجراء التاكد من الكمية  
        public DataTable VerifyQuantity(string cat_code, int quantity_entered)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();

            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@cat_code", SqlDbType.NVarChar, 50);
            param[0].Value = cat_code;

            param[1] = new SqlParameter("@quantity_entered", SqlDbType.Int);
            param[1].Value = quantity_entered;

            Dt = DAL.SelectData("VerifyQuantity", param);

            DAL.close();
            return Dt;
        }
        // اجراء لاضافة البيانات لقاعدة البيانات
        public void ADD_SPEND(string cat_code, DateTime spend_date,int dep_id)

        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@spend_code", SqlDbType.NVarChar, 50);
            param[0].Value = cat_code;

            param[1] = new SqlParameter("@spend_date", SqlDbType.DateTime);
            param[1].Value = spend_date;
            
            param[2] = new SqlParameter("@dep_id", SqlDbType.Int);
            param[2].Value = dep_id;

            DAL.ExcuteCommand("ADD_SPEND", param);
            DAL.close();

        }

        // اجراء لاضافة البيانات لقاعدة البيانات
        public void ADD_SPEND_DETALIS(string pro_code, string pro_name, string pro_unit ,int pro_quantity, string spend_code)
        
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

           

            DAL.ExcuteCommand("ADD_SPEND_DETALIS", param);
            DAL.close();

        }


    }
}
