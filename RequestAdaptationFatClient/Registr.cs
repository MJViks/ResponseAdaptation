﻿using System;
using Microsoft.Win32;
using System.Windows;

namespace RequestAdaptationFatClient
{
    class Registr
    {
        public static string UI = "Empty", PW = "Empty", SE = "Empty";//логин пароль и запоминанее пароля в реестре
        public static string OrganizationName = "", DirPath = "";//название организации и путь сохранения файлов
        public static double DocLM = 0, DocTM = 0, DocRM = 0, DocBM = 0;//отсутпы сохраненные в реестре

        static public void Registry_Get()//получение параметров
        {
            RegistryKey registry = Registry.CurrentUser;
            RegistryKey key = registry.CreateSubKey("CarFood");
            try
            {
                UI = key.GetValue("UI").ToString();
                PW = key.GetValue("PW").ToString();
                SE = key.GetValue("SE").ToString();
            }
            catch
            {
                key.SetValue("UI", String.Empty);
                key.SetValue("PW", String.Empty);
                key.SetValue("SE", String.Empty);
            }
        }

        static public void Registry_Set(string ui, string pw, string se)//установка параметров пароля
        {
            RegistryKey registry = Registry.CurrentUser;
            RegistryKey key = registry.CreateSubKey("CarFood");
            try
            {
                key.SetValue("UI", ui);
                key.SetValue("PW", pw);
                key.SetValue("SE", se);
                Registry_Get();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        static public void SaveEnterReg(string Login, string Password)//сохранение пароля и логина в реестре
        {
            RegistryKey registry = Registry.CurrentUser;
            RegistryKey key = registry.CreateSubKey("CarFood");
            try
            {
                key.SetValue("Pa", Password);
                key.SetValue("Id", Login);
                Registry_Get();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }



        public static void ConfigurationGet()//сохранение отступов
        {
            RegistryKey registry = Registry.CurrentUser;
            RegistryKey registryKey = registry.CreateSubKey("CarFood");
            RegistryKey subKey = registryKey.CreateSubKey("Configuration");
            try
            {
                OrganizationName = subKey.GetValue("OrganizationName").ToString();
                DirPath = subKey.GetValue("DirPath").ToString();
                DocLM = Convert.ToDouble(subKey.GetValue("DocLM").ToString());
                DocTM = Convert.ToDouble(subKey.GetValue("DocTM").ToString());
                DocRM = Convert.ToDouble(subKey.GetValue("DocRM").ToString());
                DocBM = Convert.ToDouble(subKey.GetValue("DocBM").ToString());
            }
            catch
            {
                subKey.SetValue("OrganizationName", "Empty");
                subKey.SetValue("DirPath", "Empty");
                subKey.SetValue("DocLM", 0.0);
                subKey.SetValue("DocTM", 0.0);
                subKey.SetValue("DocRM", 0.0);
                subKey.SetValue("DocBM", 0.0);
            }
        }

        public static void MajorConfigurationSet(string Organization_Name)//настройка имени организации
        {
            RegistryKey registry = Registry.CurrentUser;
            RegistryKey registryKey = registry.CreateSubKey("CarFood");
            RegistryKey subKey = registryKey.CreateSubKey("Configuration");
            subKey.SetValue("OrganizationName", Organization_Name);
            ConfigurationGet();
        }

        public static void DocumentConfigurationSet(string Path, decimal DocLM, decimal DocTM,//пусть сохранения документа
            decimal DocRM, decimal DocBM)
        {
            RegistryKey registry = Registry.CurrentUser;
            RegistryKey registryKey = registry.CreateSubKey("CarFood");
            RegistryKey subKey = registryKey.CreateSubKey("Configuration");

            subKey.SetValue("DirPath", Path);
            subKey.SetValue("DocLM", DocLM);
            subKey.SetValue("DocTM", DocTM);
            subKey.SetValue("DocRM", DocRM);
            subKey.SetValue("DocBM", DocBM);
            ConfigurationGet();
        }


    }
}