using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CETJ_STOCK.BL
{
    class CLS_Units


    {
        // اجراء لجلب كافة عناصر الوحدات
        public DataTable GET_ALL_UNITS()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_ALL_UNITS", null);
            DAL.close();
            return Dt;
        }

        // اجراء اضافة 

        public void ADD_UNITS( string unit_name, string code_ar = null,string code_en = null)

        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@unit_name", SqlDbType.VarChar, 50);
            param[0].Value = unit_name;

            param[1] = new SqlParameter("@unit_code_ar", SqlDbType.VarChar, 50);
            param[1].Value = code_ar;

            param[2] = new SqlParameter("@unit_code_en", SqlDbType.VarChar, 50);
            param[2].Value = code_en;

            DAL.ExcuteCommand("ADD_UNITS", param);
            DAL.close();

        }

        // اجراء تعديل البيانات لقاعدة البيانات

        public void UPDATE_UNITS(int unit_id, string unit_name, string code_ar = null, string code_en = null)

        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@unit_id", SqlDbType.VarChar, 50);
            param[0].Value = unit_id;

            param[1] = new SqlParameter("@unit_name", SqlDbType.VarChar, 50);
            param[1].Value = unit_name;

            param[2] = new SqlParameter("@unit_code_ar", SqlDbType.VarChar, 50);
            param[2].Value = code_ar;

            param[3] = new SqlParameter("@unit_code_en", SqlDbType.VarChar, 50);
            param[3].Value = code_en;

            DAL.ExcuteCommand("UPDATE_UNITS", param);
            DAL.close();

        }

        // اجراء حذف البيانات لقاعدة البيانات
        public void DeleteUnit(String ID)

        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;
            DAL.ExcuteCommand("DeleteUnit", param);
            DAL.close();

        }
    }
}
