using System;
using System.Data;
using System.Data.SqlClient;

namespace RequestAdaptationFatClient
{
    class DBConnect
    {
        public static string pc = "31.31.196.234";
        public static string cat = "u0831431_RequestAdaptation";
        public static string ui = "u0831431_LantaAdmin";
        public static string Pass = "A8fYznv993kcyDG";
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
        private static string qrClient = "SELECT id_Client as 'ID' , Name as 'Название', Email, TelNum as " +
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
            qrEmployee = "select id_Employee as 'ID', Surname as 'Фамилия', [Name] as 'Имя', Surname as 'Фамилия', " +
            "Post as 'Должность', RoleName as 'Роль' from Employee join [User] on [User_ID] = [id_User]";

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

        public static void ClearTable(string tableName)
        {
            string sqlExpression = "TRUNCATE TABLE " + tableName;
            {
                sql.Open();
                SqlCommand command = new SqlCommand(sqlExpression, sql);
                command.ExecuteNonQuery();
                sql.Close();
            }
        }

        public static void FillAllTable() { 
      
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