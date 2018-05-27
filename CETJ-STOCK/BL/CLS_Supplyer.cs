using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CETJ_STOCK.BL
{
    class CLS_Supplyer
    {

        // اجراء لجلب كافة عناصر الموردين
        public DataTable GET_ALL_SUPPLYER()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_ALL_SUPPLYER", null);
            DAL.close();
            return Dt;
        } 


        public void ADD_SUPPLYER(string supplyer_name, string supplyer_phone, string supplyer_addrees, string supplyer_note)

        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@supplyer_name", SqlDbType.NVarChar, 50);
            param[0].Value = supplyer_name;

            param[1] = new SqlParameter("@supplyer_phone", SqlDbType.NVarChar, 50);
            param[1].Value = supplyer_phone;

            param[2] = new SqlParameter("@supplyer_addrees", SqlDbType.NVarChar, 50);
            param[2].Value = supplyer_addrees;
            
            param[3] = new SqlParameter("@supplyer_note", SqlDbType.NVarChar, 50);
            param[3].Value = supplyer_note;



            DAL.ExcuteCommand("ADD_SUPPLYER", param);
            DAL.close();

        }

        // اجراء التاكد من اسم المورد
        public DataTable VerifySupplyer(string supplyer_name)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@supplyer_name", SqlDbType.NVarChar, 50);
            param[0].Value = supplyer_name;

            Dt = DAL.SelectData("VerifySupplyer", param);

            DAL.close();
            return Dt;
        }

        // اجراء حذف البيانات لقاعدة البيانات
        public void DeleteSupplyer(String supplyer_id)

        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@supplyer_id", SqlDbType.VarChar, 50);
            param[0].Value = supplyer_id;
            DAL.ExcuteCommand("DeleteSupplyer", param);
            DAL.close();

        }


        // اجراء بحث البيانات لقاعدة البيانات
        public DataTable SearchSupplyer(string ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;

            Dt = DAL.SelectData("SearchSupplyer", param);
            DAL.close();
            return Dt;
        }


      
    }
}
