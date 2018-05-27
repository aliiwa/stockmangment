using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace CETJ_STOCK.BL
{
    class CLS_Sub_Cat
    {
        // اجراء لجلب كافة عناصر الوحدات
        public DataTable GET_ALL_SUB_CAT()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_ALL_SUB_CAT", null);
            DAL.close();
            return Dt;
        }

        // اجراء اضافة 

        public void ADD_SUB_CAT(string sub_cat_name)

        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@sub_cat_name", SqlDbType.NVarChar, 50);
            param[0].Value = sub_cat_name;

            DAL.ExcuteCommand("ADD_SUB_CAT", param);
            DAL.close();

        }

        // اجراء تعديل البيانات لقاعدة البيانات

        public void UPDATE_SUB_CAT(int sub_cat_id, string sub_cat_name)

        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@sub_cat_id", SqlDbType.Int);
            param[0].Value = sub_cat_id;

            param[1] = new SqlParameter("@sub_cat_name", SqlDbType.VarChar, 50);
            param[1].Value = sub_cat_name;

            DAL.ExcuteCommand("UPDATE_SUB_CAT", param);
            DAL.close();

        }

        // اجراء حذف البيانات لقاعدة البيانات
        public void DELETE_SUB_CAT(String sub_cat_id)

        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = sub_cat_id;
            DAL.ExcuteCommand("DELETE_SUB_CAT", param);
            DAL.close();

        }
    }
}
