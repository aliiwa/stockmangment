using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace CETJ_STOCK.BL
{
    class CLS_Category
    {
        // اجراء لجلب كافة عناصر الوحدة من قاعدة البيانات
        public DataTable GET_ALL_UNITS()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_ALL_UNITS", null);
            DAL.close();
            return Dt; 
        }

        // اجراء لجلب كافة عناصر الاقسام من قاعدة البيانات
        public DataTable GET_ALL_DEPARTMNT()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_ALL_DEPARTMNT", null);
            DAL.close();
            return Dt;
        }

       

        // اجراء لجلب كافة عناصر التصنيفات من قاعدة البيانات
        public DataTable GET_ALL_SUB_CAT()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_ALL_SUB_CAT", null);
            DAL.close();
            return Dt;
        }

        // اجراء لجلب كافة عناصر الاصناف من قاعدة البيانات
        public DataTable GET_ALL_CATEGORY()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_ALL_CATEGORY", null);
            DAL.close();
            return Dt;
        }


        // اجراء لاضافة البيانات لقاعدة البيانات
        public void ADD_CATEGORY( string cat_code, string cat_name, string quantity,
                                 int dep_id,int unit_id, int sub_cat)
            
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@cat_code", SqlDbType.NVarChar,50);
            param[0].Value = cat_code;

            param[1] = new SqlParameter("@cat_name", SqlDbType.VarChar, 50);
            param[1].Value = cat_name;

            param[2] = new SqlParameter("@quantity", SqlDbType.VarChar, 50);
            param[2].Value = quantity;

            param[3] = new SqlParameter("@dep_id", SqlDbType.Int);
            param[3].Value = dep_id;

            param[4] = new SqlParameter("@unit_id", SqlDbType.Int);
            param[4].Value = unit_id;

            param[5] = new SqlParameter("@sub_cat_id", SqlDbType.Int);
            param[5].Value = sub_cat;
            

            DAL.ExcuteCommand("ADD_CATEGORY", param);
            DAL.close();

        }

        // اجراء  تحديث على البيانات لقاعدة البيانات
        public void UPDATE_CATEGORY(string cat_code, string cat_name, string quantity,
                                 int dep_id, int unit_id, int sub_cat)

        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@cat_code", SqlDbType.NVarChar,50);
            param[0].Value = cat_code;

            param[1] = new SqlParameter("@cat_name", SqlDbType.NVarChar, 50);
            param[1].Value = cat_name;

            param[2] = new SqlParameter("@quantity", SqlDbType.NVarChar, 50);
            param[2].Value = quantity;

            param[3] = new SqlParameter("@dep_id", SqlDbType.Int);
            param[3].Value = dep_id;

            param[4] = new SqlParameter("@unit_id", SqlDbType.Int);
            param[4].Value = unit_id;

            param[5] = new SqlParameter("@sub_cat_id", SqlDbType.Int);
            param[5].Value = sub_cat;

            
            DAL.ExcuteCommand("UPDATE_CATEGORY", param);
            DAL.close();

        }

        // اجراء حذف البيانات لقاعدة البيانات
        public void DeleteCategory(String ID)

        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar,50);
            param[0].Value = ID;
            DAL.ExcuteCommand("DeleteCategory", param);
            DAL.close();

        }

        // دالة البحث عن منتج
        public DataTable SearchCategory(string ID)
         {
             DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
             DataTable Dt = new DataTable();
             SqlParameter[] param = new SqlParameter[1];
             param[0] = new SqlParameter("@ID", SqlDbType.VarChar,50);
             param[0].Value = ID;
             Dt = DAL.SelectData("SearchCategory", param);
             DAL.close();
             return Dt;
         }


        public DataTable MAX_CAT_ID()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("MAX_CAT_ID", null);
            DAL.close();
            return Dt;
        }

    }
}
