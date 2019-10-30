using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RequestAdaptationFatClient
{
    class Authoriz
    {
        public static bool vhod; //проверкка входа
        public static string role;

        public static void Auth(string Login, string Password)
        {
            
            try
            {
                DBConnect.sql.Open();

                // Проверка наличия учетной записи с указанным логином
                SqlCommand CheckLoginCmd = new SqlCommand(@"SELECT Count(*) FROM [User]
                                        WHERE Login=@Login COLLATE Cyrillic_General_CS_AS", DBConnect.sql);
                CheckLoginCmd.Parameters.AddWithValue("@Login", Login);
                int LoginCount = (int)CheckLoginCmd.ExecuteScalar();

                // Если учетная запись существует
                if (LoginCount > 0)
                {
                    // Проверяем в соответствии с учетной записью заданный пароль
                    SqlCommand CheckPasswordCmd = new SqlCommand(@"SELECT Count(*) FROM [User]
                                        WHERE Login=@Login and Pass=@Password COLLATE Cyrillic_General_CS_AS", DBConnect.sql);
                    CheckPasswordCmd.Parameters.AddWithValue("@Login", Login);
                    CheckPasswordCmd.Parameters.AddWithValue("@Password", Crypt.GetHash(Password));
                    int PasswordCount = (int)CheckPasswordCmd.ExecuteScalar();

                DBConnect.sql.Close();
                // Если пароль соответствует
                if (PasswordCount > 0)
                    {
                        vhod = true;
                        DBConnect.sql.Open();

                        SqlCommand cmd = new SqlCommand("SELECT roleName from [user] where Login = '" + Login + "'", DBConnect.sql);
                        role = (string)cmd.ExecuteScalar();
                        DBConnect.sql.Close();
                    }
                    else // Если пароль не подходит
                    {
                        vhod = false;
                    }
                }
                else{
                    vhod = false;
                }
            }
            catch (Exception ex){
                MessageBox.Show(ex.Message.ToString() + "\n\rНомер ошибки: " + ex.HResult.ToString());
            }
            finally
            {
                DBConnect.sql.Close();
            }
        }
    }
}