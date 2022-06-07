using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ТестовоеЗаданиеБД
{
    class Database
    {
        private string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=MyDatabase.mdb";
        private OleDbConnection connection;
        public enum GrandRevoke{
            Grand,
            Revoke
        };

        //Открытие и закрытие соединения
        private void OpenConnection()
        {
            connection = new OleDbConnection(connectString);
            connection.Open();
        }
        private void CloseConnection()
        {
            connection = new OleDbConnection(connectString);
            connection.Close();
        }

        //Выборка должности выбранного сотрудника
        public string SelectJob(int id)
        {
            OleDbCommand command;
            OpenConnection();
            string currentJob = "SELECT [Должность] FROM [Сотрудники] WHERE [Код]=@id";
            command = new OleDbCommand(currentJob, connection);
            command.Parameters.AddWithValue("@id", id);
            currentJob = command.ExecuteScalar().ToString();
            CloseConnection();
            return currentJob;
        }

        //Выборка списка подразделений
        public List<string> SelectJobPart()
        {
            OleDbCommand command;
            OpenConnection();
            //я не знаю чего ему надо, как говорится вчера is not null работало, а сегодня то ли access умный то ли я не понимаю его
            string jobparts = "SELECT DISTINCT [Название подразделение] FROM [Сотрудники] WHERE [Название подразделение] IS NOT NULL";
            command = new OleDbCommand(jobparts, connection);
            OleDbDataReader dataReader = command.ExecuteReader();
            List<string> values = new List<string>();
            while(dataReader.Read())
            {
                values.Add(dataReader.GetValue(0).ToString());
            }
            CloseConnection();
            return values;
        }

        //Выполнение запроса выборки
        public void SelectQuery(DataGridView dataTableView, string query)
        {
            //Ожидание обновления основной базы для актуальной выборки
            Thread.Sleep(600);
            //Выборка
            OpenConnection(); 
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, connection);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "[Сотрудники]");
            dataTableView.DataSource = dataSet.Tables["[Сотрудники]"];
            CloseConnection();
        }

        //Выполнение запроса удаления
        public void DeleteQuery(DataGridView dataTableView)
        {
            OpenConnection();
            OleDbCommand command;

            DialogResult confirm = MessageBox.Show(
                "Вы действительно хотите удалить эту запись, отменить это дейтсвие будет невозможно", 
                "Подтверждение",
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question
                );

            if(confirm == DialogResult.Yes)
            {
                string query = "DELETE FROM [Сотрудники] WHERE [Код]=@id";
                command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@id", dataTableView.CurrentRow.Cells[0].Value);
                command.ExecuteNonQuery();
            }
            CloseConnection();
        }

        //Выполнение запроса обновления
        public void UpdateQuery(string[] values, int id)
        {
            OpenConnection();
            OleDbCommand command;
            string query = "UPDATE [Сотрудники] SET " +
                            "[ФИО]='" + values[0] + "', " +
                            "[Дата рождения]='" + values[1] + "', " +
                            "[Пол]='" + values[2] + "', " +
                            "[Название подразделение]='" + values[4] + "', " +
                            "[ФИО руководителя]='" + values[5] + "' " +
                            " WHERE [Код]=@id";
            command = new OleDbCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
            CloseConnection();

            /* not working: not updated
            string query = "UPDATE [Сотрудники] SET [ФИО]=@Name WHERE [Код]=@id";
            command.Parameters.AddWithValue("@Name", values[0]);
            command.Parameters.AddWithValue("@Date", values[1]);
            command.Parameters.AddWithValue("@Gender", values[2]);
            */
        }

        //Выполнение запроса вставки
        public void InsertQuery(string[] values)
        {
            OpenConnection();
            OleDbCommand command;

            string query = "INSERT INTO [Сотрудники] ([ФИО], [Дата рождения], [Пол], [Должность]) VALUES (@Name, @Date, @Gender, @Job)";
            command = new OleDbCommand(query, connection);
            command.Parameters.AddWithValue("@Name", values[0]);
            command.Parameters.AddWithValue("@Date", values[1]);
            command.Parameters.AddWithValue("@Gender", values[2]);
            command.Parameters.AddWithValue("@Job", values[3]);
            command.ExecuteNonQuery();

            CloseConnection();
        }   

        //Выполнение запроса повышения/понижения в должности
        public void GrandOrRevokeQuery(GrandRevoke grandRevoke, int id)
        {
            OleDbCommand command;
            string currentJob = SelectJob(id);
            if (grandRevoke == GrandRevoke.Grand)
            {
                switch (currentJob)
                {
                    case "Рабочий":
                        currentJob = "Контроллер";
                        break;
                    case "Контроллер":
                        currentJob = "Руководитель подразделения";
                        break;
                }
            }
            else
            {
                switch (currentJob)
                {
                    case "Руководитель подразделения":
                        currentJob = "Контроллер";
                        break;
                    case "Контроллер":
                        currentJob = "Рабочий";
                        break;
                }
            }
            string query = "UPDATE [Сотрудники] SET [Должность]='" + currentJob + "' WHERE [Код]=@id";
            OpenConnection();
            command = new OleDbCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
            CloseConnection();
        }
    }
}
