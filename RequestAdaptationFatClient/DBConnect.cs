using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RequestAdaptationFatClient
{
    class DBConnect
    {
        private static string pc = "31.31.196.234";
        private static string cat = "u0831431_RequestAdaptation";
        private static string ui = "u0831431_LantaAdmin";
        private static string Pass = "A8fYznv993kcyDG";
        public static SqlConnection sql = new SqlConnection("Data Source = " + pc + "; Initial Catalog = " + cat + ";" +
             "Persist Security Info = true; User ID = " + ui + "; Password = \"" + Pass + "\""); //строка подключения

        public static DataTable dtContract = new DataTable();
        public static DataTable dtSoftware = new DataTable();
        public static DataTable dtClient = new DataTable();
        public static DataTable dtSoftwareClient = new DataTable();
        public static DataTable dtUser = new DataTable();
        public static DataTable dtFeedback = new DataTable();
        public static DataTable dtRequest = new DataTable();
        public static DataTable dtEmployee = new DataTable();
        public static string qrClient = "SELECT id_Client as 'ID' , Name as 'Название', Email, TelNum as " +
            "'Номер телефона', [User_ID] as 'Код аккаунта' FROM dbo.Client",
             qrContract = "select id_Contract as 'ID', Contact_Num as 'Номер контракта', [Employee_ID] as 'ID сотрудника', [Client_ID] as 'ID клиента', [text] " +
            "as 'Текст договора', [Date_Create] as 'Дата договора' from Contract",
             qrSoftware = "Select id_Software as 'ID', [Name] as 'Название', Price as 'Цена' from Software",
             qrSoftwareClient = "select [ID_Software_Client] as 'ID', [Software_ID] as 'ID ПО', [Client_ID] as 'ID Клиента', " +
            "[StartDate] as 'Дата начала', [StopDate] as 'Дата окончания' from Software_Client",
             qrUser = "select id_User as 'ID', [Login] as 'Логин', Pass as 'Пароль', RoleName as 'Роль' from [User]",
             qrFeedback = "select id_Feedback as 'ID', Header as 'Заголовок', [text] as 'Текст'," +
            " Software_Name as 'Программный продукт', Email from Feedback",
             qrRequest = "select id_Request as 'ID', [Client_ID] as 'ID Клиента', [TEXT] as 'Текст заявки'," +
            " Software_Name as 'Название программного продукта' from Request",
            qrEmployee = "select id_Employee as 'ID', Surname as 'Фамилия', [Name] as 'Имя', Midlename as 'Отчество', " +
            "Post as 'Должность', User_ID as 'Код аккаунта' from Employee";

        public static BindingSource bsFeedback = new BindingSource();
        public static BindingSource bsEmployee = new BindingSource();
        public static BindingSource bsSoftware = new BindingSource();
        public static BindingSource bsSoftwareClient = new BindingSource();
        public static BindingSource bsClient = new BindingSource();
        public static BindingSource bsRequest = new BindingSource();
        public static BindingSource bsContract = new BindingSource();
        public static BindingSource bsUser = new BindingSource();

        public static SqlDataAdapter daFeedback = new SqlDataAdapter();
        public static SqlDataAdapter daEmployee = new SqlDataAdapter();
        public static SqlDataAdapter daSoftware = new SqlDataAdapter();
        public static SqlDataAdapter daSoftwareClient = new SqlDataAdapter();
        public static SqlDataAdapter daClient = new SqlDataAdapter();
        public static SqlDataAdapter daRequest = new SqlDataAdapter();
        public static SqlDataAdapter daContract = new SqlDataAdapter();
        public static SqlDataAdapter daUser = new SqlDataAdapter();
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

        private static BindingSource BindSource(string query, DataTable dt)
        {
            SqlDataAdapter da = new SqlDataAdapter(query, sql);
            da.Fill(dt);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = dt;
            return bSource;
        }

        public static void UpdateFeedbackAdapter()
        {
            try { 
            SqlCommandBuilder cBuilder = new SqlCommandBuilder(daFeedback);
            daFeedback.SelectCommand = new SqlCommand(qrFeedback, sql);
            daFeedback.Update(dtFeedback);
                FillTableBinding();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не все поля валидны!!!\n\rПерепроверьте!\n\r" + ex.Message.ToString());
            }
        }
        public static void UpdateClientAdapter()
        {
            try
            {
                SqlCommandBuilder cBuilder = new SqlCommandBuilder(daClient);
            daClient.SelectCommand = new SqlCommand(qrClient, sql);
            daClient.Update(dtClient);
                FillTableBinding();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не все поля валидны!!!\n\rПерепроверьте!\n\r" + ex.Message.ToString());
            }
}

        public static void UpdateContractAdapter()
        {
            try
            {
                SqlCommandBuilder cBuilder = new SqlCommandBuilder(daContract);
            daContract.SelectCommand = new SqlCommand(qrContract, sql);
            daContract.Update(dtContract);
                FillTableBinding();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не все поля валидны!!!\n\rПерепроверьте!\n\r" + ex.Message.ToString());
            }
        }
        public static void UpdateUserAdapter()
        {
            try
            {
                SqlCommandBuilder cBuilder = new SqlCommandBuilder(daUser);
            daUser.SelectCommand = new SqlCommand(qrUser, sql);
            daUser.Update(dtUser);
                FillTableBinding();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не все поля валидны!!!\n\rПерепроверьте!\n\r" + ex.Message.ToString());
            }
        }
        public static void UpdateRequestAdapter()
        {
            try
            {
                SqlCommandBuilder cBuilder = new SqlCommandBuilder(daRequest);
            daRequest.SelectCommand = new SqlCommand(qrRequest, sql);
            daRequest.Update(dtRequest);
                FillTableBinding();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не все поля валидны!!!\n\rПерепроверьте!\n\r" + ex.Message.ToString());
            }
        }
        public static void UpdateEmployeeAdapter()
        {
            try
            {
                SqlCommandBuilder cBuilder = new SqlCommandBuilder(daEmployee);
            daEmployee.SelectCommand = new SqlCommand(qrEmployee, sql);
            daEmployee.Update(dtEmployee);
                FillTableBinding();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не все поля валидны!!!\n\rПерепроверьте!\n\r" + ex.Message.ToString());
            }
        }
        public static void UpdateSoftwareAdapter()
        {
            try
            {
                SqlCommandBuilder cBuilder = new SqlCommandBuilder(daSoftware);
            daSoftware.SelectCommand = new SqlCommand(qrSoftware, sql);
            daSoftware.Update(dtSoftware);
                FillTableBinding();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не все поля валидны!!!\n\rПерепроверьте!\n\r" + ex.Message.ToString());
            }
        }
        public static void UpdateSoftwareClientAdapter()
        {
            try
            {
                SqlCommandBuilder cBuilder = new SqlCommandBuilder(daSoftwareClient);
            daSoftwareClient.SelectCommand = new SqlCommand(qrSoftwareClient, sql);
            daSoftwareClient.Update(dtSoftwareClient);
                FillTableBinding();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Не все поля валидны!!!\n\rПерепроверьте!\n\r" + ex.Message.ToString());
            }
        }


        public static void ConnectStringEdit(string IP, string Password, string UserName, string Catalog)
        {
            cat = Catalog;
            ui = UserName;
            Pass = Password;
            pc = IP;
        } 

        
        public static void FillTableBinding() 
        {
            bsFeedback = BindSource(qrFeedback, dtFeedback);

            bsClient = BindSource(qrClient, dtClient);

            bsContract = BindSource(qrContract, dtContract);

            bsSoftware = BindSource(qrSoftware, dtSoftware);

            bsRequest = BindSource(qrRequest, dtRequest);

            bsUser = BindSource(qrUser, dtUser);

            bsSoftwareClient = BindSource(qrSoftwareClient, dtSoftwareClient);

            bsEmployee = BindSource(qrEmployee, dtEmployee);

            FillDataTable(qrContract, dtContract);

            FillDataTable(qrClient, dtClient);
     
            FillDataTable(qrFeedback, dtFeedback);
      
            FillDataTable(qrRequest, dtRequest);
      
            FillDataTable(qrSoftware, dtSoftware);
      
            FillDataTable(qrSoftwareClient, dtSoftwareClient);
       
            FillDataTable(qrEmployee, dtEmployee);
      
            FillDataTable(qrUser, dtUser);
        }
    }
}