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

        public EditTable(MainForm form)
        {
            InitializeComponent();
            mainForm = form;
            SendBtn.Text = "Добавить";
            InputLeader.Enabled = InputJobPart.Enabled = false;
        }

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
            SendBtn.Text = "Изменить";

        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            if(NameInput.Text == "")
            {
                MessageBox.Show("Неоставляйте пустых полей", "Предупреждение", MessageBoxButtons.OK);
                return;
            }
            string[] values = {
                    NameInput.Text,
                    DateInput.Value.ToString("d"),
                    GenderInput.SelectedItem.ToString(),
                    JobInput.SelectedItem.ToString(),
                    InputJobPart.Text,
                    InputLeader.Text
            };
            if (SendBtn.Text == "Изменить")
            {
                db.UpdateQuery(values, id);
            }
            else if (SendBtn.Text == "Добавить")
            {
                db.InsertQuery(values);
            }
            db.LoadFullList(mainForm.dataTableView);
            this.Dispose();
        }
    }
}
