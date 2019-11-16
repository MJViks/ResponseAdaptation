using System;
using System.Data.SqlClient;

namespace RequestAdaptation
{
    class DBActions
    {
        public static SqlCommand cmd = new SqlCommand(string.Empty, DBConnect.sql);
        //Добавление названия и типа процедуры 
        private static void spConfiguration(string spName)
        {
            cmd.CommandText = spName;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
        }

        public static string execScalar()
        {
            DBConnect.sql.Open();
            string scalar = DBActions.cmd.ExecuteScalar().ToString();
            DBConnect.sql.Close();
            return scalar;
        }

        public static string RequestASP_Insert(string Text, string Software_Name, string Name, string Email)
        {
            spConfiguration("RequestASP_Insert");
            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Text", Text);
                cmd.Parameters.AddWithValue("@Software_Name", Software_Name);
                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.Parameters.AddWithValue("@Email", Email);
                DBConnect.sql.Open();
                cmd.ExecuteNonQuery();
                return "Заявка успешно отправлена!";
            }
            catch (SqlException ex)
            {
                return ex.Message.ToString();
            }
            finally
            {
                DBConnect.sql.Close();
            }
        }




        //Вызов процедуры Добавления в таблицу "Feedback"
        public static string Feedback_Insert(string Header, string Text, string SoftwareName, string Email)
        {
            spConfiguration("Feedback_Insert");
            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Header", Header);
                cmd.Parameters.AddWithValue("@Text", Text);
                cmd.Parameters.AddWithValue("@Software_Name", SoftwareName);
                cmd.Parameters.AddWithValue("@Email", Email);
                DBConnect.sql.Open();
                cmd.ExecuteNonQuery();
                return "Спасибо за ваш отзыв!";
            }
            catch (SqlException ex)
            {
                return ex.ToString() + "\n\rНомер ошибки: " + ex.HResult.ToString();
            }
            finally
            {
                DBConnect.sql.Close();
            }
        }

        //Вызов процедуры обновления данных в таблице "Feedback"
        public static void Feedback_Update(Int32 ID_Feedback, string Header, string Text, 
            string SoftwareName, int Email)
        {
            spConfiguration("Feedback_Update");
            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ID_Feedback", Header);
                cmd.Parameters.AddWithValue("@Header", Header);
                cmd.Parameters.AddWithValue("@Text", Text);
                cmd.Parameters.AddWithValue("@Software_Name", SoftwareName);
                cmd.Parameters.AddWithValue("@Email", Email);
                DBConnect.sql.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                 //ex.Message.ToString() + "\n\rНомер ошибки: " + ex.HResult.ToString();
            }
            finally
            {
                DBConnect.sql.Close();
            }
        }


        //Вызов процедуры удаления данных в таблице "Feedback"
        public static void Feedback_Delete(Int32 ID)
        {
            spConfiguration("Feedback_Delete");
            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ID_Feedback", ID);
                DBConnect.sql.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                 //MessageBox.Show(ex.Message.ToString() + "\n\rНомер ошибки: " + ex.HResult.ToString());
            }
            finally
            {
                DBConnect.sql.Close();
            }
        }

        //Вызов процедуры Добавления в таблицу "Employee"
        public static void Employee_Insert(string Surname, string Name, string Midlename, 
            string Post, Int32 User_Id)
        {
            spConfiguration("Employee_Insert");
            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Surname", Surname);
                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.Parameters.AddWithValue("@Midlename", Midlename);
                cmd.Parameters.AddWithValue("@Post", Post);
                cmd.Parameters.AddWithValue("@User_ID", User_Id);
                DBConnect.sql.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                 //MessageBox.Show(ex.Message.ToString() + "\n\rНомер ошибки: " + ex.HResult.ToString());
            }
            finally
            {
                DBConnect.sql.Close();
            }
        }

        //Вызов процедуры обновления данных в таблице "Employee"
        public static void Employee_Update(Int32 ID_Employee, string Surname, string Name, 
            string Midlename, string Post, Int32 User_Id)
        {
            spConfiguration("Employee_Update");
            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ID_Employee", ID_Employee);
                cmd.Parameters.AddWithValue("@Surname", Surname);
                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.Parameters.AddWithValue("@Midlename", Midlename);
                cmd.Parameters.AddWithValue("@Post", Post);
                cmd.Parameters.AddWithValue("@User_ID", User_Id);
                DBConnect.sql.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                 //MessageBox.Show(ex.Message.ToString() + "\n\rНомер ошибки: " + ex.HResult.ToString());
            }
            finally
            {
                DBConnect.sql.Close();
            }
        }

        //Вызов процедуры удаления данных в таблице "Employee"
        public static void Check_Delete(Int32 ID)
        {
            spConfiguration("Employee_Delete");
            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ID_Employee", ID);
                DBConnect.sql.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                 //MessageBox.Show(ex.Message.ToString() + "\n\rНомер ошибки: " + ex.HResult.ToString());
            }
            finally
            {
                DBConnect.sql.Close();
            }
        }

        //Вызов процедуры Добавления в таблицу "Contract"
        public static void Contract_Insert(int ContractNum, int Employee_ID, int Client_ID, 
            string Text, string Date_Create)
        {
            spConfiguration("Contract_Insert");
            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Surn_Client", ContractNum);
                cmd.Parameters.AddWithValue("@Name_Client", Employee_ID);
                cmd.Parameters.AddWithValue("@Midn_Client", Client_ID);
                cmd.Parameters.AddWithValue("@Mob_Num_Client", Text);
                cmd.Parameters.AddWithValue("@Sale_Id", Date_Create);
                DBConnect.sql.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                 //MessageBox.Show(ex.Message.ToString() + "\n\rНомер ошибки: " + ex.HResult.ToString());
            }
            finally
            {
                DBConnect.sql.Close();
            }
        }

        //Вызов процедуры обновления данных в таблице "Contract"
        public static void Contract_Update(int ID_Contract, int ContractNum, int Employee_ID, int Client_ID,
            string Text, string Date_Create)
        {
            spConfiguration("Contract_Update");
            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ID_Contract", ID_Contract);
                cmd.Parameters.AddWithValue("@Surn_Client", ContractNum);
                cmd.Parameters.AddWithValue("@Name_Client", Employee_ID);
                cmd.Parameters.AddWithValue("@Midn_Client", Client_ID);
                cmd.Parameters.AddWithValue("@Mob_Num_Client", Text);
                cmd.Parameters.AddWithValue("@Sale_Id", Date_Create);
                DBConnect.sql.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                 //MessageBox.Show(ex.Message.ToString() + "\n\rНомер ошибки: " + ex.HResult.ToString());
            }
            finally
            {
                DBConnect.sql.Close();
            }
        }

        //Вызов процедуры удаления данных в таблице "Contract"
        public static void Contract_Delete(Int32 ID)
        {
            spConfiguration("Contract_Delete");
            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ID_Contract", ID);
                DBConnect.sql.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                 //MessageBox.Show(ex.Message.ToString() + "\n\rНомер ошибки: " + ex.HResult.ToString());
            }
            finally
            {
                DBConnect.sql.Close();
            }
        }

        //Вызов процедуры Добавления в таблицу "User"
        public static void User_Insert(string Login, string Password, string RoleName)
        {
            spConfiguration("User_Insert");
            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Login", Login);
                cmd.Parameters.AddWithValue("@Pass", Password);
                cmd.Parameters.AddWithValue("@RoleName", RoleName);
                DBConnect.sql.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                 //MessageBox.Show(ex.Message.ToString() + "\n\rНомер ошибки: " + ex.HResult.ToString());
            }
            finally
            {
                DBConnect.sql.Close();
            }
        }

        //Вызов процедуры обновления данных в таблице "User"
        public static void User_Update(int ID_User, string Login, string Password, string RoleName)
        {
            spConfiguration("User_Update");
            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ID_User", ID_User);
                cmd.Parameters.AddWithValue("@Login", Login);
                cmd.Parameters.AddWithValue("@Pass", Password);
                cmd.Parameters.AddWithValue("@RoleName", RoleName);
                DBConnect.sql.Open();
                DBConnect.sql.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                 //MessageBox.Show(ex.Message.ToString() + "\n\rНомер ошибки: " + ex.HResult.ToString());
            }
            finally
            {
                DBConnect.sql.Close();
            }
        }

        //Вызов процедуры удаления данных в таблице "User"
        public static void User_Delete(Int32 ID)
        {
            spConfiguration("User_Delete");
            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ID_User", ID);
                DBConnect.sql.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                 //MessageBox.Show(ex.Message.ToString() + "\n\rНомер ошибки: " + ex.HResult.ToString());
            }
            finally
            {
                DBConnect.sql.Close();
            }
        }

        //Вызов процедуры Добавления в таблицу "Client"
        public static void Client_Insert(string Name, string Email, string TelNum,int User_ID)
        {
            spConfiguration("Client_Insert");
            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.Parameters.AddWithValue("@TelNum", TelNum);
                cmd.Parameters.AddWithValue("@User_ID", User_ID);
                DBConnect.sql.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                 //MessageBox.Show(ex.Message.ToString() + "\n\rНомер ошибки: " + ex.HResult.ToString());
            }
            finally
            {
                DBConnect.sql.Close();
            }
        }

        //Вызов процедуры обновления данных в таблице "Client"
        public static void Client_Update(int ID_Client, string Name, string Email, string TelNum, int User_ID)
        {
            spConfiguration("Client_Update");
            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ID_Client", ID_Client);
                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.Parameters.AddWithValue("@TelNum", TelNum);
                cmd.Parameters.AddWithValue("@User_ID", User_ID);
                DBConnect.sql.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                 //MessageBox.Show(ex.Message.ToString() + "\n\rНомер ошибки: " + ex.HResult.ToString());
            }
            finally
            {
                DBConnect.sql.Close();
            }
        }

        //Вызов процедуры удаления данных в таблице "Client"
        public static void Client_Delete(Int32 ID)
        {
            spConfiguration("Client_Delete");
            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ID_Client", ID);
                DBConnect.sql.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                 //MessageBox.Show(ex.Message.ToString() + "\n\rНомер ошибки: " + ex.HResult.ToString());
            }
            finally
            {
                DBConnect.sql.Close();
            }
        }

        //Вызов процедуры Добавления в таблицу "Request"
        public static void Request_Insert(int Client_ID, string Text, string SoftwareName)
        {
            spConfiguration("Request_Insert");
            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Client_ID", Client_ID);
                cmd.Parameters.AddWithValue("@Text", Text);
                cmd.Parameters.AddWithValue("@Software_Name", SoftwareName);
                DBConnect.sql.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                 //MessageBox.Show(ex.Message.ToString() + "\n\rНомер ошибки: " + ex.HResult.ToString());
            }
            finally
            {
                DBConnect.sql.Close();
            }
        }

        //Вызов процедуры обновления данных в таблице "Request"
        public static void Request_Update(int ID_Request, int Client_ID, string Text, string SoftwareName)
        {
            spConfiguration("Request_Update");
            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ID_Request", ID_Request);
                cmd.Parameters.AddWithValue("@Client_ID", Client_ID);
                cmd.Parameters.AddWithValue("@Text", Text);
                cmd.Parameters.AddWithValue("@Software_Name", SoftwareName);
                DBConnect.sql.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                 //MessageBox.Show(ex.Message.ToString() + "\n\rНомер ошибки: " + ex.HResult.ToString());
            }
            finally
            {
                DBConnect.sql.Close();
            }
        }

        //Вызов процедуры удаления данных в таблице "Request"
        public static void Request_Delete(Int32 ID)
        {
            spConfiguration("Request_Delete");
            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ID_Request", ID);
                DBConnect.sql.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                //MessageBox.Show(ex.Message.ToString() + "\n\rНомер ошибки: " + ex.HResult.ToString());
            }
            finally
            {
                DBConnect.sql.Close();
            }
        }

        //Вызов процедуры Добавления в таблицу "Software"
        public static void Software_Insert(string Name, float Price)
        {
            spConfiguration("Software_Insert");
            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.Parameters.AddWithValue("@Price", Price);
                DBConnect.sql.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                //MessageBox.Show(ex.Message.ToString() + "\n\rНомер ошибки: " + ex.HResult.ToString());
            }
            finally
            {
                DBConnect.sql.Close();
            }
        }

        //Вызов процедуры обновления данных в таблице "Software"
        public static void Software_Update(int ID_Software, string Name, float Price)
        {
            spConfiguration("Software_Update");
            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ID_Software", ID_Software);
                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.Parameters.AddWithValue("@Price", Price);
                DBConnect.sql.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                //MessageBox.Show(ex.Message.ToString() + "\n\rНомер ошибки: " + ex.HResult.ToString());
            }
            finally
            {
                DBConnect.sql.Close();
            }
        }

        //Вызов процедуры удаления данных в таблице "Software"
        public static void Software_Delete(Int32 ID)
        {
            spConfiguration("Software_Delete");
            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ID_Software", ID);
                DBConnect.sql.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                //MessageBox.Show(ex.Message.ToString() + "\n\rНомер ошибки: " + ex.HResult.ToString());
            }
            finally
            {
                DBConnect.sql.Close();
            }
        }

       //Вызов процедуры Добавления в таблицу "Software_Client"
        public static void ESoftware_Client_Insert(int Client_ID, int Software_ID, string StartDate, string StopDate)
        {
            spConfiguration("Software_Client_Insert");
            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Client_ID",Client_ID);
                cmd.Parameters.AddWithValue("@Software_ID", Software_ID);
                cmd.Parameters.AddWithValue("@StartDate", StartDate);
                cmd.Parameters.AddWithValue("@StopDate", StopDate);
                DBConnect.sql.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                //MessageBox.Show(ex.Message.ToString() + "\n\rНомер ошибки: " + ex.HResult.ToString());
            }
            finally
            {
                DBConnect.sql.Close();
            }
        }

        //Вызов процедуры обновления данных в таблице "Software_Client"
        public static void Software_Client_Update(int ID_Software_Client,int Client_ID, int Software_ID, string StartDate, string StopDate)
        {
            spConfiguration("Software_Client_Update");
            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ID_Software_Client", ID_Software_Client);
                cmd.Parameters.AddWithValue("@Client_ID", Client_ID);
                cmd.Parameters.AddWithValue("@Software_ID", Software_ID);
                cmd.Parameters.AddWithValue("@StartDate", StartDate);
                cmd.Parameters.AddWithValue("@StopDate", StopDate);
                DBConnect.sql.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                //MessageBox.Show(ex.Message.ToString() + "\n\rНомер ошибки: " + ex.HResult.ToString());
            }
            finally
            {
                DBConnect.sql.Close();
            }
        }

        //Вызов процедуры удаления данных в таблице "Software_Client"
        public static void Software_Client_Delete(Int32 ID)
        {
            spConfiguration("Software_Client_Delete");
            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ID_Employee_Type", ID);
                DBConnect.sql.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                //MessageBox.Show(ex.Message.ToString() + "\n\rНомер ошибки: " + ex.HResult.ToString());
            }
            finally
            {
                DBConnect.sql.Close();
            }
        }
    }
}
