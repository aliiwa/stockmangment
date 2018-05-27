using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace CETJ_STOCK.BL
{
    class CLS_inv_back
    {
        // اجراء لجلب كافة عناصر الوحدة من قاعدة البيانات
        public DataTable SEARCH_INV_BACK_1()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("SEARCH_INV_BACK_1", null);
            DAL.close();
            return Dt;
        }


        /**************************************************************/


        // دالة البحث عن منتج
        public DataTable SEARCH_INV_BACK_2(string text_search)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@text_search", SqlDbType.VarChar, 50);
            param[0].Value = text_search;
            Dt = DAL.SelectData("SEARCH_INV_BACK_2", param);
            DAL.close();
            return Dt;
        }
    }
}
