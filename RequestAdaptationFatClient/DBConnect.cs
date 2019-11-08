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
            "'Номер телефона', RoleName as 'Имя роли' FROM dbo.Client join [User] on [User_ID] = [ID_User]",
             qrContract = "select id_Contract as 'ID', Contact_Num as 'Номер контракта', CONCAT([Employee].Surname, " +
            "[Employee].Name, [Employee].Midlename) as 'ФИО Сотрудника', [Client].[Name] as 'Наиминование клиента', [text] " +
            "as 'Текст договора', [Date_Create] as 'Дата договора'    from Contract join Employee on Employee_ID = id_Employee " +
            "join Client on id_Client = Client_ID",
             qrSoftware = "Select id_Software as 'ID', [Name] as 'Название', Price as 'Цена' from Software",
             qrSoftwareClient = "select [Software].[Name] as 'Наиминование ПО', [Software].[id_Software] as 'ID ПО', " +
            "[Client].[id_Client] as 'ID Клиента', [Client].[Name] as 'Наиминование клиента'  from Software_Client join " +
            "Client on Client_ID = id_Client join Software on Software_ID = id_Software",
             qrUser = "select id_User as 'ID', [Login] as 'Логин', Pass as 'Пароль', RoleName as 'Роль' from [User]",
             qrFeedback = "select id_Feedback as 'ID', Header as 'Заголовок', [text] as 'Текст'," +
            " Software_Name as 'Программный продукт', Email from Feedback",
             qrRequest = "select id_Request as 'ID', Client.[Name] as 'Наиминование клиениа', [TEXT] as 'Текст заявки'," +
            " Software_Name as 'Название программного продукта' from Request join Client on id_Client = Client_id",
            qrEmployee = "select id_Employee as 'ID', Surname as 'Фамилия', [Name] as 'Имя', Midlename as 'Отчество', " +
            "Post as 'Должность', RoleName as 'Роль' from Employee join [User] on [User_ID] = [id_User]";

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
            SqlCommandBuilder cBuilder = new SqlCommandBuilder(daFeedback);
            daFeedback.SelectCommand = new SqlCommand(qrFeedback, sql);
            daFeedback.Update(dtFeedback);
        }
        public static void UpdateClientAdapter()
        {
            SqlCommandBuilder cBuilder = new SqlCommandBuilder(daClient);
            daClient.SelectCommand = new SqlCommand(qrClient, sql);
            daClient.Update(dtClient);
        }

        public static void UpdateContractAdapter()
        {
            SqlCommandBuilder cBuilder = new SqlCommandBuilder(daContract);
            daContract.SelectCommand = new SqlCommand(qrContract, sql);
            daContract.Update(dtContract);
        }
        public static void UpdateUserAdapter()
        {
            SqlCommandBuilder cBuilder = new SqlCommandBuilder(daUser);
            daUser.SelectCommand = new SqlCommand(qrUser, sql);
            daUser.Update(dtUser);
        }
        public static void UpdateRequestAdapter()
        {
            SqlCommandBuilder cBuilder = new SqlCommandBuilder(daRequest);
            daRequest.SelectCommand = new SqlCommand(qrRequest, sql);
            daRequest.Update(dtRequest);
        }
        public static void UpdateEmployeeAdapter()
        {
            SqlCommandBuilder cBuilder = new SqlCommandBuilder(daEmployee);
            daEmployee.SelectCommand = new SqlCommand(qrEmployee, sql);
            daEmployee.Update(dtEmployee);
        }
        public static void UpdateSoftwareAdapter()
        {
            SqlCommandBuilder cBuilder = new SqlCommandBuilder(daSoftware);
            daSoftware.SelectCommand = new SqlCommand(qrSoftware, sql);
            daSoftware.Update(dtSoftware);
        }
        public static void UpdateSoftwareClientAdapter()
        {
            SqlCommandBuilder cBuilder = new SqlCommandBuilder(daSoftwareClient);
            daSoftwareClient.SelectCommand = new SqlCommand(qrSoftwareClient, sql);
            daSoftwareClient.Update(dtSoftwareClient);
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