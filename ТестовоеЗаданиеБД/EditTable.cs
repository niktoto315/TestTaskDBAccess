using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ТестовоеЗаданиеБД
{
    public partial class EditTable : Form
    {
        private int id;
        private MainForm mainForm;
        Database db = new Database();

        //Конструктор для добавления
        public EditTable(MainForm form)
        {
            InitializeComponent();
            mainForm = form;
            btnSend.Text = "Добавить";
            InputLeader.Enabled = InputJobPart.Enabled = false;
        }

        //Конструктор для изменений
        public EditTable(MainForm form, DataGridViewRow row)
        {
            InitializeComponent();
            mainForm = form;
            id = Int32.Parse(row.Cells[0].Value.ToString());
            NameInput.Text = row.Cells[1].Value.ToString();
            DateInput.Value = DateTime.Parse(row.Cells[2].Value.ToString());
            GenderInput.SelectedItem = row.Cells[3].Value.ToString();
            JobInput.SelectedItem = row.Cells[4].Value.ToString();
            InputJobPart.Text = row.Cells[5].Value.ToString();
            InputLeader.Text = row.Cells[6].Value.ToString();
            btnSend.Text = "Изменить";

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            //Проверка на пустые поля
            if (NameInput.Text == "")
            {
                MessageBox.Show("Неоставляйте пустых полей", "Предупреждение", MessageBoxButtons.OK);
                return;
            }
            //Считывание значений с формы
            string[] values = {
                    NameInput.Text,
                    DateInput.Value.ToString("d"),
                    GenderInput.SelectedItem.ToString(),
                    JobInput.SelectedItem.ToString(),
                    InputJobPart.Text,
                    InputLeader.Text
            };
            //Отправка запросов
            if (btnSend.Text == "Изменить")
            {
                db.UpdateQuery(values, id);
            }
            else if (btnSend.Text == "Добавить")
            {
                db.InsertQuery(values);
            }
            //Обновление данных на главной форме
            db.SelectQuery(mainForm.dataTableView, "SELECT * FROM [Сотрудники]");
            this.Dispose();
        }
    }
}
