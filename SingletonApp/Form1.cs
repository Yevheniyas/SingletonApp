using SingletonLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SingletonApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            // Используем dbManager Singleton для подключения к базе данных
            dbManager.Instance.ConnectToDatabase();

            // Логируем действие
            Logger.Instance.Log("Кнопка 'Connect to Database' была нажата.");

            // Отображаем сообщение пользователю
            MessageBox.Show("Подключение к базе данных выполнено.");
        }

        private void btnSaveDocument_Click(object sender, EventArgs e)
        {
            // Используем DocumentSaver Singleton для сохранения документа
            DocumentSaver.Instance.SaveDocument("Документ 1");

            // Логируем действие
            Logger.Instance.Log("Кнопка 'Save Document' была нажата.");

            // Отображаем сообщение пользователю
            MessageBox.Show("Документ сохранён.");
        }
    }
}
