using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Security.AccessControl;

using Microsoft.Win32;

using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.Win32;
using Cachetopia.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;

namespace Cachetopia
{
    public partial class Form2 : MaterialForm
    {
        public Form2()
        {
            InitializeComponent();
        }

        // Variables
        public static string dateClear;
        public static string timeClear;
        public static string DateAndTime;

        public static string configPath = "C:\\Cachetopia\\config.txt";

        private static void autostartProgram()
        {
            try
            {
                // Получение пути к исполняемому файлу программы
                string executablePath = @"C:\Cachetopia\Cachetopia.exe";

                // Открытие раздела реестра, отвечающего за автозапуск текущего пользователя
                RegistryKey regKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

                try
                {
                    // Добавление записи в реестр для автозапуска программы
                    regKey.SetValue("Cachetopia", executablePath);
                    Console.WriteLine("Программа успешно добавлена в автозапуск.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ошибка при добавлении программы в автозапуск: " + ex.Message);
                }
                finally
                {
                    // Закрытие раздела реестра
                    regKey.Close();
                }

            }
            catch (Exception ex)
            {

            }
        }

        private static void removeStartup()
        {
            // Указываете путь к исполняемому файлу вашей программы
            string applicationPath = @"C:\Cachetopia\Cachetopia.exe";

            // Открываем ключ реестра, отвечающий за автозагрузку
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true))
            {
                // Удаляем запись о программе из автозапуска
                key.DeleteValue("Cachetopia", false);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                // Save data from config path to varibales
                try
                {
                    // Читаем все строки из файла
                    string[] lines = File.ReadAllLines(configPath);

                    dateClear = lines[0];
                    //timeClear = lines[1];
                    DateAndTime = lines[0];

                    timeClear = dateClear.Substring(11);
                    dateClear = dateClear.Substring(0, 10);

                    datePicker.Value = DateTime.Parse(dateClear);
                    timePicker.Value = DateTime.Parse(timeClear);
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message, "Error");
                }

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        // Add to startup programm
        private void materialButton1_Click(object sender, EventArgs e)  
        {
            autostartProgram();
            MessageBox.Show("The program was successfully added to autorun", "Message");
        }

        private void removeFromStartup_Click(object sender, EventArgs e)
        {
            removeStartup();
            MessageBox.Show("The program was successfully removed from autorun", "Message");
        }

        private void timePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void materialLabel3_Click(object sender, EventArgs e)
        {

        }

        private void removeFromStartupLabel_Click(object sender, EventArgs e)
        {

        }
        // DateTimePicker value
        private void applyBtn_Click(object sender, EventArgs e)
        {
            dateClear = datePicker.Value.ToString();
            timeClear = timePicker.Value.ToString();

            try
            {
                File.WriteAllText(configPath, "");
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

            try
            {
                File.WriteAllText(configPath, dateClear);
                File.WriteAllText(configPath, timeClear);
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

            MessageBox.Show("Your settings have been applied", "Message");
        }
    }
}
