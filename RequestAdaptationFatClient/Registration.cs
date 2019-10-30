using System;

namespace RequestAdaptationFatClient
{
    class Registration
    {
        public static bool ok; // закочена регистрация или нет

        public static String RegNewUser(string login, string pass, string checkpass, string RoleName) // регистрация нового пользователя
        {
            try
            {
            if (login == "" || pass == "" || checkpass == "" || RoleName == "") // если одно из поле пустое
                return "Поля не заполнены!\nЗаполните все поля!";
            else
            {
                if (pass != checkpass) return "Пароли не совпадают"; // проверка на соответствие полей паролей
                else
                {
                    Int32 logchk; // проверка на уникальность логина
                    DBActions.cmd.CommandText = "select count(*) from [dbo].[user]" +
                                "where " +
                                "(Login ='" + login + "')"; // возвращает запрос на проверку занятости введенного логина                    
                    logchk = Convert.ToInt32(DBActions.execScalar());
                    if (logchk >= 1) return "Данный логин уже существует!";
                    else
                    {
                        
                            if (login.Length > 4 && pass.Length > 4) { 
                            logchk = 0;
                                
                            DBActions.User_Insert(login, Crypt.GetHash(pass), RoleName); // добавляет зарегестрированные данные в бд 
                            DBActions.cmd.CommandType = System.Data.CommandType.Text;
                            DBActions.cmd.CommandText = "select id_user from [user] where [login] = '" + login + "'";
                            logchk = Convert.ToInt32(DBActions.execScalar());
                            if (logchk != 0)
                            {
                                //DBActions.client_Insert(SurnClient, NameClient, MidnClient, MobileNum, 1, logchk); //Добавление клиента к аккаунту
                                ok = true;
                                return "Регистрация успешно завершена!";
                             
                            }
                            return "Возникла непредвиденная ошибка!";
                            }
                            else
                                return "Логин/пароль слишком короткий!\nМинимум 5 символов!";
                       

                    }

                }
            }
            }
            catch (Exception ex)
            {
                return ex.Message.ToString() + "\n\rНомер ошибки: " + ex.HResult.ToString();
            }
            finally
            {
                DBConnect.sql.Close();
            }
        }
    }
}