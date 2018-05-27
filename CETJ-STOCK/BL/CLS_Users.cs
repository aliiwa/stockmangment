using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace CETJ_STOCK.BL
{
    class CLS_Users
    {

        // اجراء لجلب كافة عناصر المستخدمين
        public DataTable GET_ALL_USERS()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_ALL_USERS", null);
            DAL.close();
            return Dt;
        }

        public DataTable GET_ALL_SCREAN()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_ALL_SCREAN", null);
            DAL.close();
            return Dt;
        }

        public DataTable GET_ALL_LISTS()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_ALL_LISTS", null);
            DAL.close();
            return Dt;
        }

        // اجراء لجلب كافة عناصر المستخدمين
        public DataTable MAX_USER_ID()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("MAX_USER_ID", null);
            DAL.close();
            return Dt;
        }


        public DataTable SP_LOGIN(string user_name,string password)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@username", SqlDbType.VarChar, 50);
            param[0].Value = user_name;

            param[1] = new SqlParameter("@password", SqlDbType.NVarChar,50);
            param[1].Value = password;

            DAL.open();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("SP_LOGIN", param);
            DAL.close();
            return Dt;
        }


        public DataTable search_priv(int user_id, int list_id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@user_id", SqlDbType.Int);
            param[0].Value = user_id;

            param[1] = new SqlParameter("@list_id", SqlDbType.Int);
            param[1].Value = list_id;

            DAL.open();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("search_priv", param);
            DAL.close();
            return Dt;
        }

        public DataTable GET_ALL_DIS(int user_id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@user_id", SqlDbType.Int);
            param[0].Value = user_id;

            
            DAL.open();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_ALL_DIS", param);
            DAL.close();
            return Dt;
        }

        public DataTable GET_USER_ID(string user_name)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@user_name", SqlDbType.NVarChar,50);
            param[0].Value = user_name;


            DAL.open();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_USER_ID", param);
            DAL.close();
            return Dt;
        }

        // اجراء لاضافة البيانات لقاعدة البيانات
        public void ADD_USERS(int user_id, string full_name, string user_name, string password)

        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@user_id", SqlDbType.Int);
            param[0].Value = user_id;

            param[1] = new SqlParameter("@full_name", SqlDbType.NVarChar, 50);
            param[1].Value = full_name;

            param[2] = new SqlParameter("@user_name", SqlDbType.VarChar, 50);
            param[2].Value = user_name;

            param[3] = new SqlParameter("@password", SqlDbType.VarChar, 50);
            param[3].Value = password;

            DAL.ExcuteCommand("ADD_USERS", param);
            DAL.close();

        }


        // اجراء التعديل البيانات لقاعدة البيانات
        public void UPDATE_USERS(int user_id, string full_name, string user_name, string password)

        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@user_id", SqlDbType.Int);
            param[0].Value = user_id;

            param[1] = new SqlParameter("@full_name", SqlDbType.NVarChar, 50);
            param[1].Value = full_name;

            param[2] = new SqlParameter("@user_name", SqlDbType.VarChar, 50);
            param[2].Value = user_name;

            param[3] = new SqlParameter("@password", SqlDbType.VarChar, 50);
            param[3].Value = password;

            DAL.ExcuteCommand("UPDATE_USERS", param);
            DAL.close();

        }

        // اجراء التعديل البيانات لقاعدة البيانات
        public void UPDATE_USER_EX(int user_id, string full_name, string user_name)

        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@user_id", SqlDbType.Int);
            param[0].Value = user_id;

            param[1] = new SqlParameter("@full_name", SqlDbType.NVarChar, 50);
            param[1].Value = full_name;

            param[2] = new SqlParameter("@user_name", SqlDbType.VarChar, 50);
            param[2].Value = user_name;



            DAL.ExcuteCommand("UPDATE_USER_EX", param);
            DAL.close();

        }

        // اجراء التعديل البيانات لقاعدة البيانات
        public void UPDATE_PRIV(int user_id, int screen_id, Boolean priv_display,Boolean priv_add,Boolean priv_edit,Boolean priv_delete)

        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[6];

            param[0] = new SqlParameter("@user_id", SqlDbType.Int);
            param[0].Value = user_id;

            param[1] = new SqlParameter("@screen_id", SqlDbType.Int);
            param[1].Value = screen_id;

            param[2] = new SqlParameter("@priv_display", SqlDbType.Bit);
            param[2].Value = priv_display;

            param[3] = new SqlParameter("@priv_add", SqlDbType.Bit);
            param[3].Value = priv_add;

            param[4] = new SqlParameter("@priv_edit", SqlDbType.Bit);
            param[4].Value = priv_edit;

            param[5] = new SqlParameter("@priv_delete", SqlDbType.Bit);
            param[5].Value = priv_delete;

            DAL.ExcuteCommand("UPDATE_PRIV", param);
            DAL.close();

        }

        // اجراء حذف البيانات لقاعدة البيانات
        public void DELETE_USERES(int user_id)

        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@user_id", SqlDbType.Int);
            param[0].Value = user_id;


            DAL.ExcuteCommand("DELETE_USERES", param);
            DAL.close();

        }


        /**********************************************************************/

        // اجراء لاضافة البيانات لقاعدة البيانات
        public void ADD_MONITER(int user_id, DateTime date, string time, string process, string screens)

        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[5];

            param[0] = new SqlParameter("@user_id", SqlDbType.Int);
            param[0].Value = user_id;

            param[1] = new SqlParameter("@date", SqlDbType.Date);
            param[1].Value = date;

            param[2] = new SqlParameter("@time", SqlDbType.NVarChar,50);
            param[2].Value = time;

            param[3] = new SqlParameter("@process", SqlDbType.VarChar, 50);
            param[3].Value = process;

            param[4] = new SqlParameter("@screens", SqlDbType.VarChar, 50);
            param[4].Value = screens;

            

            DAL.ExcuteCommand("ADD_MONITER", param);
            DAL.close();

        }

        public DataTable GET_ALL_MONITER()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_ALL_MONITER", null);
            DAL.close();
            return Dt;
        }


    }
}
