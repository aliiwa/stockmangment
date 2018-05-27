using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CETJ_STOCK.BL
{
    class CLS_Department
    {
        // اجراء لجلب كافة عناصر الوحدات
        public DataTable GET_ALL_DEPARTMNT()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_ALL_DEPARTMNT", null);
            DAL.close();
            return Dt;
        }

        // اجراء اضافة 

        public void ADD_DEPARTMINT(string dep_name)

        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@dep_name", SqlDbType.NVarChar, 50);
            param[0].Value = dep_name;
            
            DAL.ExcuteCommand("ADD_DEPARTMINT", param);
            DAL.close();

        }

        // اجراء تعديل البيانات لقاعدة البيانات

        public void UPDATE_DEPARTMINT(int dep_id, string dep_name)

        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@dep_id", SqlDbType.Int);
            param[0].Value = dep_id;

            param[1] = new SqlParameter("@dep_name", SqlDbType.VarChar, 50);
            param[1].Value = dep_name;

            DAL.ExcuteCommand("UPDATE_DEPARTMINT", param);
            DAL.close();

        }

        // اجراء حذف البيانات لقاعدة البيانات
        public void DELETE_DEPARTMINT(String dep_id)

        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@dep_id", SqlDbType.VarChar, 50);
            param[0].Value = dep_id;
            DAL.ExcuteCommand("DELETE_DEPARTMINT", param);
            DAL.close();

        }
    }
}
