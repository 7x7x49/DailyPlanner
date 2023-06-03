using System;
using System.IO;
using System.Data.SQLite;
using System.Windows.Forms;

namespace DailyPlanner
{
    public partial class MainForm : Form
    {
        private SQLiteConnection connection;
        private SQLiteCommand command;
        private static string logFile = "log.txt";

        public MainForm()
        {
            InitializeComponent();
            InitializeLogger();

            Log("Приложение запущено");

            // Инициализация подключения к базе данных
            connection = new SQLiteConnection("Data Source=daily_planner.db;Version=3;");
            connection.Open();

            // Создание таблицы, если она не существует
            command = new SQLiteCommand("CREATE TABLE IF NOT EXISTS Tasks (TaskText TEXT, TaskDate TEXT)", connection);
            command.ExecuteNonQuery();

            // Загрузка записей из базы данных
            LoadTasks();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Закрытие подключения к базе данных при закрытии формы
            connection.Close();
        }

        //Логгирование
        static void InitializeLogger()
        {
            if (!File.Exists(logFile))
            {
                File.Create(logFile).Close();
            }
        }
        static void Log(string message)
        {
            string logmessage = $"{DateTime.Now} - {message}{Environment.NewLine}";
            File.AppendAllText(logFile, logmessage);
        }

        private void AddTaskButton_Click(object sender, EventArgs e)
        {
            string taskText = TaskTextBox.Text.Trim();
            string taskDate = TaskCalendar.SelectionStart.ToShortDateString();

            if (!string.IsNullOrEmpty(taskText))
            {
                // Добавление задачи в базу данных
                command = new SQLiteCommand("INSERT INTO Tasks (TaskText, TaskDate) VALUES (@taskText, @taskDate)", connection);
                command.Parameters.AddWithValue("@taskText", taskText);
                command.Parameters.AddWithValue("@taskDate", taskDate);
                command.ExecuteNonQuery();

                // Очистка полей ввода после добавления задачи
                TaskTextBox.Text = "";
                TaskCalendar.SetDate(DateTime.Today);

                // Загрузка обновленного списка задач
                LoadTasks();

                Log("Пользователь добавил план");
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            // Очистка списка задач и базы данных
            command = new SQLiteCommand("DELETE FROM Tasks", connection);
            command.ExecuteNonQuery();

            // Загрузка пустого списка задач
            LoadTasks();
        }

        private void LoadTasks()
        {
            // Загрузка задач из базы данных
            command = new SQLiteCommand("SELECT TaskText, TaskDate FROM Tasks", connection);
            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                TaskListBox.Items.Clear();

                while (reader.Read())
                {
                    string taskText = reader["TaskText"].ToString();
                    string taskDate = reader["TaskDate"].ToString();
                    TaskListBox.Items.Add($"Дата: {taskDate} Задача: {taskText}");
                }
            }
        }

        private void StatisticsButton_Click(object sender, EventArgs e)
        {
            if (TaskListBox.Items.Count != 0)
            {
                StatisticsForm statisticsForm = new StatisticsForm();
                statisticsForm.Show();
                Log("Пользователь открыл окно статистики");
            }
            else
            {
                MessageBox.Show("Планы не найдены.\nВведите планы.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                Log("Пользователь пытался открыть окно статистики без внесения планов");
            }
        }
    }
}
