using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CETJ_STOCK.BL
{
    class CLS_Reports_Screan
    {
        // اجراء لجلب كافة عناصر الاقسام
        public DataTable GET_ALL_DEPARTMNT()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_ALL_DEPARTMNT", null);
            DAL.close();
            return Dt;
        }

        // اجراء لجلب كافة عناصر الاقسام
        public DataTable GET_ALL_SUPPLYER()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_ALL_SUPPLYER", null);
            DAL.close();
            return Dt;
        }

        public DataTable GET_ALL_CATEGORY()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_ALL_CATEGORY", null);
            DAL.close();
            return Dt;
        }


        /*********************************** تقارير اذن الصرف ***************************************************/

        /** اجراء بحث البيانات لقاعدة البيانات
         * حسب رقم الصرف
         * حسب القسم
         * بين تاريخين
         **/
        public DataTable SEARCH_B2D_SPEND(string text_search,DateTime date_from, DateTime date_to,int dep_id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();

            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@pro_code", SqlDbType.VarChar, 50);
            param[0].Value = text_search;

            param[1] = new SqlParameter("@date_from", SqlDbType.DateTime);
            param[1].Value = date_from;

            param[2] = new SqlParameter("@date_to", SqlDbType.DateTime);
            param[2].Value = date_to;

            param[3] = new SqlParameter("@dep_id", SqlDbType.Int);
            param[3].Value = dep_id;

            Dt = DAL.SelectData("SEARCH_B2D_SPEND", param);
            DAL.close();
            return Dt;
        }

        /** اجراء بحث البيانات لقاعدة البيانات
         * حسب رقم الصرف
         **/
        public DataTable SEARCH_RE_SPEND_1(string text_search)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@pro_code", SqlDbType.VarChar, 50);
            param[0].Value = text_search;

            Dt = DAL.SelectData("SEARCH_RE_SPEND_1", param);
            DAL.close();
            return Dt;
        }

        /** اجراء بحث البيانات لقاعدة البيانات
        
         * حسب القسم
         
         **/
        public DataTable SEARCH_RE_SPEND_2(int dep_id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@dep_id", SqlDbType.Int);
            param[0].Value = dep_id;

            Dt = DAL.SelectData("SEARCH_RE_SPEND_2", param);
            DAL.close();
            return Dt;
        }

        /** اجراء بحث البيانات لقاعدة البيانات
        
         * حسب القسم
         
         **/
        public DataTable SEARCH_RE_SPEND_3(DateTime date_from, DateTime date_to)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();

            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@date_from", SqlDbType.DateTime);
            param[0].Value = date_from;

            param[1] = new SqlParameter("@date_to", SqlDbType.DateTime);
            param[1].Value = date_to;

            Dt = DAL.SelectData("SEARCH_RE_SPEND_3", param);
            DAL.close();
            return Dt;
        }

        /** اجراء بحث البيانات لقاعدة البيانات
       
        * حسب تاريخ معين
        
        **/
        public DataTable SEARCH_RE_SPEND_4(DateTime date)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@date", SqlDbType.DateTime);
            param[0].Value = date;

           

            Dt = DAL.SelectData("SEARCH_RE_SPEND_4", param);
            DAL.close();
            return Dt;
        }


        /*********************************** تقارير اذن الصرف ***************************************************/

        /*********************************** تقارير اذن الاستلام ***************************************************/




        /*********************************** تقارير اذن الاستلام ***************************************************/

        /** اجراء بحث البيانات لقاعدة البيانات
         * حسب رقم الصرف
         * حسب القسم
         * بين تاريخين
         **/
        public DataTable SEARCH_B2D_SUPPLYE(string text_search, DateTime date_from, DateTime date_to, int dep_id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();

            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@pro_code", SqlDbType.VarChar, 50);
            param[0].Value = text_search;

            param[1] = new SqlParameter("@date_from", SqlDbType.DateTime);
            param[1].Value = date_from;

            param[2] = new SqlParameter("@date_to", SqlDbType.DateTime);
            param[2].Value = date_to;

            param[3] = new SqlParameter("@dep_id", SqlDbType.Int);
            param[3].Value = dep_id;

            Dt = DAL.SelectData("SEARCH_B2D_SPEND", param);
            DAL.close();
            return Dt;
        }

        /** اجراء بحث البيانات لقاعدة البيانات
         * حسب رقم الصرف
         **/
        public DataTable SEARCH_RE_SUPPLYE_1(string text_search)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@supplye_code", SqlDbType.VarChar, 50);
            param[0].Value = text_search;

            Dt = DAL.SelectData("SEARCH_RE_SUPPLYE_1", param);
            DAL.close();
            return Dt;
        }

        /** اجراء بحث البيانات لقاعدة البيانات
        
         * حسب القسم
         
         **/
        public DataTable SEARCH_RE_SUPPLYE_2(int supplyer_id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@supplyer_id", SqlDbType.Int);
            param[0].Value = supplyer_id;

            Dt = DAL.SelectData("SEARCH_RE_SUPPLYE_2", param);
            DAL.close();
            return Dt;
        }

        /** اجراء بحث البيانات لقاعدة البيانات
        
         * حسب القسم
         
         **/
        public DataTable SEARCH_RE_SUPPLYE_3(DateTime date_from, DateTime date_to)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();

            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@date_from", SqlDbType.DateTime);
            param[0].Value = date_from;

            param[1] = new SqlParameter("@date_to", SqlDbType.DateTime);
            param[1].Value = date_to;

            Dt = DAL.SelectData("SEARCH_RE_SUPPLYE_3", param);
            DAL.close();
            return Dt;
        }



        public DataTable SEARCH_RE_SUPPLYE_4(DateTime date)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@date", SqlDbType.DateTime);
            param[0].Value = date;

            

            Dt = DAL.SelectData("SEARCH_RE_SUPPLYE_4", param);
            DAL.close();
            return Dt;
        }

        /*********************************** تقارير اذن الاستلام ***************************************************/

        /***********************************  تقارير الاصناف***************************************************/



        public DataTable SearchCategory(string ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;

            Dt = DAL.SelectData("SearchCategory", param);
            DAL.close();
            return Dt;
        }


        public DataTable SEARCH_RE_CAT_SUB_CAT(int cat_id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@cat_id", SqlDbType.Int);
            param[0].Value = cat_id;

            Dt = DAL.SelectData("SEARCH_RE_CAT_SUB_CAT", param);
            DAL.close();
            return Dt;
        }


        public DataTable SEARCH_RE_CAT_DEP(int dep_id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@dep_id", SqlDbType.Int);
            param[0].Value = dep_id;

            Dt = DAL.SelectData("SEARCH_RE_CAT_DEP", param);
            DAL.close();
            return Dt;
        }


        /***********************************  تقارير الارصدة***************************************************/
        // اجراء لاضافة البيانات لقاعدة البيانات
        public void ADD_FIRST_QTY(DateTime date)

        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@date", SqlDbType.DateTime);
            param[0].Value = date;

            DAL.ExcuteCommand("ADD_FIRST_QTY", param);
            DAL.close();

        }

        // اجراء البحث عن الارصدة
        public DataTable SERACH_FIRST_QTY(DateTime date)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@date", SqlDbType.DateTime);
            param[0].Value = date;

            Dt = DAL.SelectData("SERACH_FIRST_QTY", param);
            DAL.close();
            return Dt ;
        }

        // اجراء البحث عن الارصدة
        public DataTable GET_FIRST_QTE()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();

            Dt = DAL.SelectData("GET_FIRST_QTE", null);
            DAL.close();
            return Dt;
        }

        // اجراء البحث عن الارصدة
        public DataTable GET_FIRST_QTE_PRINT(DateTime date)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@date", SqlDbType.DateTime);
            param[0].Value = date;

            Dt = DAL.SelectData("GET_FIRST_QTE_PRINT", param);
            DAL.close();
            return Dt;
        }


        /*********************************** تقارير الاصناف ***************************************************/

    }
}
