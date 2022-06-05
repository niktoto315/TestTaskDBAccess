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
            db.LoadFullList(dataTableView);
            foreach (var item in db.SelectJobPart())
            {
                JobParts.Items.Add(item);
            }
        }

        //Сброс фильтров
        private void btnClearSelect_Click(object sender, EventArgs e)
        {
            JobParts.SelectedIndex = Jobs.SelectedIndex = 0;
        }

        //Фильтр списка по подразделению
        private void InputJobPart_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (JobParts.SelectedItem == JobParts.Items[0])
            {
                db.LoadFullList(dataTableView);
            }
            else
            {
                string condition = JobParts.SelectedItem.ToString();
                db.LoadListofJobPart(dataTableView, condition);
            }
        }

        //Фильтр списка по должности
        private void JobsSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Jobs.SelectedItem == Jobs.Items[0])
            {
                db.LoadFullList(dataTableView);
            }
            else
            {
                string condition = Jobs.SelectedItem.ToString();
                db.LoadListofJob(dataTableView, condition);
            }
        }

        //Добавление нового
        private void buttonInsert_Click(object sender, EventArgs e)
        {
            EditTable editForm = new EditTable(this);
            editForm.Show();
        }

        //Изменение
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            EditTable editForm = new EditTable(this, dataTableView.CurrentRow);
            editForm.Show();
        }

        //Удаление
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            db.DeleteQuery(dataTableView);
            db.LoadFullList(dataTableView);
        }

        //Повышение
        private void btnGrand_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(dataTableView.CurrentRow.Cells[0].Value.ToString());
            db.GrandOrRevokeQuery(Database.GrandRevoke.Grand, id);
            db.LoadFullList(dataTableView);
        }

        //Понижение
        private void btnRevoke_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(dataTableView.CurrentRow.Cells[0].Value.ToString());
            db.GrandOrRevokeQuery(Database.GrandRevoke.Revoke, id);
            db.LoadFullList(dataTableView);
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
