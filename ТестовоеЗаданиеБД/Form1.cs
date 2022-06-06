using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ТестовоеЗаданиеБД
{
    public partial class MainForm : Form
    {
        Database db = new Database();

        public MainForm()
        {
            InitializeComponent();
            //Заполнение таблицы выборкой из БД
            db.SelectQuery(dataTableView, "SELECT * FROM [Сотрудники]");
            //Заполнение коллекции списка подразделений
            foreach (var item in db.SelectJobPart())
            {
                jobPartList.Items.Add(item);
            }
        }

        //Сброс фильтров
        private void btnClearSelect_Click(object sender, EventArgs e)
        {
            jobPartList.SelectedIndex = jobList.SelectedIndex = 0;
        }

        //Фильтр списка по подразделению
        private void jobPartList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "SELECT * FROM [Сотрудники]";
            if (jobPartList.SelectedItem != jobPartList.Items[0])
            {
                query = "SELECT * " +
                        "FROM [Сотрудники] " +
                        "WHERE [Название подразделение]='" + jobPartList.SelectedItem.ToString() + "'";
            }
            db.SelectQuery(dataTableView, query);
        }

        //Фильтр списка по должности
        private void jobList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "SELECT * FROM [Сотрудники]";
            if (jobList.SelectedItem != jobList.Items[0])
            {
                query = "SELECT * " +
                               "FROM [Сотрудники] " +
                               "WHERE [Должность]='" + jobList.SelectedItem.ToString() + "'";
            }
            db.SelectQuery(dataTableView, query);
        }

        //Добавление
        private void btnInsert_Click(object sender, EventArgs e)
        {
            EditTable editForm = new EditTable(this);
            editForm.Show();
        }

        //Изменение
        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditTable editForm = new EditTable(this, dataTableView.CurrentRow);
            editForm.Show();
        }

        //Удаление
        private void btnDelete_Click(object sender, EventArgs e)
        {
            db.DeleteQuery(dataTableView);
            db.SelectQuery(dataTableView, "SELECT * FROM [Сотрудники]");
        }

        //Повышение
        private void btnGrand_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(dataTableView.CurrentRow.Cells[0].Value.ToString());
            db.GrandOrRevokeQuery(Database.GrandRevoke.Grand, id);
            db.SelectQuery(dataTableView, "SELECT * FROM [Сотрудники]");
        }

        //Понижение
        private void btnRevoke_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(dataTableView.CurrentRow.Cells[0].Value.ToString());
            db.GrandOrRevokeQuery(Database.GrandRevoke.Revoke, id);
            db.SelectQuery(dataTableView, "SELECT * FROM [Сотрудники]");
        }

        //Переключение кнопок в зависимости от должности
        private void dataTableView_SelectionChanged(object sender, EventArgs e)
        {
            string job = dataTableView.CurrentRow.Cells["Должность"].Value.ToString();
            if (job == "Директор")
            {
                btnGrand.Enabled = false;
                btnRevoke.Enabled = false;
            }
            else if (job == "Рабочий")
            {
                btnGrand.Enabled = true;
                btnRevoke.Enabled = false;
            }
            else if (job == "Руководитель подразделения")
            {
                btnGrand.Enabled = false;
                btnRevoke.Enabled = true;
            }
            else 
            {
                btnGrand.Enabled = true;
                btnRevoke.Enabled = true;
            }
        }
    }
}
