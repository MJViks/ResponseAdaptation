using System;

namespace RequestAdaptationFatClient
{
    class Registration
    {

        public static string error; // переменная текста ошибки
        public static string head; // переменная заголовка ошибки
        public static bool ok; // закочена регистрация или нет

        public static void RegNewClient(string login, string pass, string checkpass, string SurnClient, string NameClient, string MidnClient, string MobileNum) // регистрация нового пользователя
        {
            if (login == "" || pass == "" || checkpass == "" || SurnClient == "" || NameClient == "" || MobileNum == "") // если одно из поле пустое
            {
                error = "Поля не заполнены!\nЗаполните все поля!";
                head = "Заполните поля!";
            }
            else
            {
                if (pass != checkpass) { error = "Пароли не совпадают"; head = "Пароли неверны!"; } // проверка на соответствие полей паролей
                else
                {
                    Int32 logchk; // проверка на уникальность логина
                    DBActions.cmd.CommandText = "select count(*) from [dbo].[user]" +
                                "where " +
                                "(Login ='" + login + "')"; // возвращает запрос на проверку занятости введенного логина                    
                    logchk = Convert.ToInt32(DBActions.execScalar());
                    if (logchk == 1)
                    {
                        error = "Данный логин уже существует!";
                        head = "Существующий логин!";
                    }
                    else
                    {
                        try
                        {
                            logchk = 0;
                            DBActions.User_Insert(login, Crypt.GetHash(pass), 6); // добавляет зарегестрированные данные в бд 
                            DBActions.cmd.CommandType = System.Data.CommandType.Text;
                            DBActions.cmd.CommandText = "select id_user from [user] where [login] = '" + login + "'";
                            logchk = Convert.ToInt32(DBActions.execScalar());
                            if (logchk != 0)
                            {
                                DBActions.client_Insert(SurnClient, NameClient, MidnClient, MobileNum, 1, logchk);
                                error = "Регистрация успешно завершена!";
                                head = "Успешно!";
                                ok = true;
                            }
                        }
                        catch (Exception ex)
                        {
                            error = ex.ToString();
                        }

                    }

                }
            }
        }
    }
}