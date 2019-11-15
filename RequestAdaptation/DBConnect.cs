using System;
using System.Data;
using System.Data.SqlClient;

namespace RequestAdaptation
{
    class DBConnect
    {
        private static string pc = "31.31.196.234";
        private static string cat = "u0831431_RequestAdaptation";
        private static string ui = "u0831431_LantaAdmin";
        private static string Pass = "Dr4psEmtLkgwCnq";
        public static SqlConnection sql = new SqlConnection("Data Source = " + pc + "; Initial Catalog = " + cat + ";" +
             "Persist Security Info = true; User ID = " + ui + "; Password = \"" + Pass + "\""); //строка подключения
         
        private static void FillDataTable(String query, DataTable table)
        {
            sql.Open();
            SqlCommand command = new SqlCommand(query, sql);
            SqlDataReader reader = command.ExecuteReader();
            table.Clear();
            table.Load(reader);
            reader.Close();
            sql.Close();
        }

//        private static BindingSource BindSource(string query, DataTable dt)
//        {
//            SqlDataAdapter da = new SqlDataAdapter(query, sql);
//            da.Fill(dt);
//            BindingSource bSource = new BindingSource();
//            bSource.DataSource = dt;
//            return bSource;
//        }

//        public static void UpdateFeedbackAdapter()
//        {
//            try { 
//            SqlCommandBuilder cBuilder = new SqlCommandBuilder(daFeedback);
//            daFeedback.SelectCommand = new SqlCommand(qrFeedback, sql);
//            daFeedback.Update(dtFeedback);
//                FillTableBinding();
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("Не все поля валидны!!!\n\rПерепроверьте!\n\r" + ex.Message.ToString());
//            }
//        }
//        public static void UpdateClientAdapter()
//        {
//            try
//            {
//                SqlCommandBuilder cBuilder = new SqlCommandBuilder(daClient);
//            daClient.SelectCommand = new SqlCommand(qrClient, sql);
//            daClient.Update(dtClient);
//                FillTableBinding();
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("Не все поля валидны!!!\n\rПерепроверьте!\n\r" + ex.Message.ToString());
//            }
//}

//        public static void UpdateContractAdapter()
//        {
//            try
//            {
//                SqlCommandBuilder cBuilder = new SqlCommandBuilder(daContract);
//            daContract.SelectCommand = new SqlCommand(qrContract, sql);
//            daContract.Update(dtContract);
//                FillTableBinding();
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("Не все поля валидны!!!\n\rПерепроверьте!\n\r" + ex.Message.ToString());
//            }
//        }
//        public static void UpdateUserAdapter()
//        {
//            try
//            {
//                SqlCommandBuilder cBuilder = new SqlCommandBuilder(daUser);
//            daUser.SelectCommand = new SqlCommand(qrUser, sql);
//            daUser.Update(dtUser);
//                FillTableBinding();
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("Не все поля валидны!!!\n\rПерепроверьте!\n\r" + ex.Message.ToString());
//            }
//        }
//        public static void UpdateRequestAdapter()
//        {
//            try
//            {
//                SqlCommandBuilder cBuilder = new SqlCommandBuilder(daRequest);
//            daRequest.SelectCommand = new SqlCommand(qrRequest, sql);
//            daRequest.Update(dtRequest);
//                FillTableBinding();
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("Не все поля валидны!!!\n\rПерепроверьте!\n\r" + ex.Message.ToString());
//            }
//        }
//        public static void UpdateEmployeeAdapter()
//        {
//            try
//            {
//                SqlCommandBuilder cBuilder = new SqlCommandBuilder(daEmployee);
//            daEmployee.SelectCommand = new SqlCommand(qrEmployee, sql);
//            daEmployee.Update(dtEmployee);
//                FillTableBinding();
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("Не все поля валидны!!!\n\rПерепроверьте!\n\r" + ex.Message.ToString());
//            }
//        }
//        public static void UpdateSoftwareAdapter()
//        {
//            try
//            {
//                SqlCommandBuilder cBuilder = new SqlCommandBuilder(daSoftware);
//            daSoftware.SelectCommand = new SqlCommand(qrSoftware, sql);
//            daSoftware.Update(dtSoftware);
//                FillTableBinding();
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("Не все поля валидны!!!\n\rПерепроверьте!\n\r" + ex.Message.ToString());
//            }
//        }
//        public static void UpdateSoftwareClientAdapter()
//        {
//            try
//            {
//                SqlCommandBuilder cBuilder = new SqlCommandBuilder(daSoftwareClient);
//            daSoftwareClient.SelectCommand = new SqlCommand(qrSoftwareClient, sql);
//            daSoftwareClient.Update(dtSoftwareClient);
//                FillTableBinding();

//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("Не все поля валидны!!!\n\rПерепроверьте!\n\r" + ex.Message.ToString());
//            }
//        }


        public static void ConnectStringEdit(string IP, string Password, string UserName, string Catalog)
        {
            cat = Catalog;
            ui = UserName;
            Pass = Password;
            pc = IP;
        } 

        
        //public static void FillTableBinding() 
        //{
        //    bsFeedback = BindSource(qrFeedback, dtFeedback);

        //    bsClient = BindSource(qrClient, dtClient);

        //    bsContract = BindSource(qrContract, dtContract);

        //    bsSoftware = BindSource(qrSoftware, dtSoftware);

        //    bsRequest = BindSource(qrRequest, dtRequest);

        //    bsUser = BindSource(qrUser, dtUser);

        //    bsSoftwareClient = BindSource(qrSoftwareClient, dtSoftwareClient);

        //    bsEmployee = BindSource(qrEmployee, dtEmployee);

        //    FillDataTable(qrContract, dtContract);

        //    FillDataTable(qrClient, dtClient);
     
        //    FillDataTable(qrFeedback, dtFeedback);
      
        //    FillDataTable(qrRequest, dtRequest);
      
        //    FillDataTable(qrSoftware, dtSoftware);
      
        //    FillDataTable(qrSoftwareClient, dtSoftwareClient);
       
        //    FillDataTable(qrEmployee, dtEmployee);
      
        //    FillDataTable(qrUser, dtUser);
        //}
    }
}