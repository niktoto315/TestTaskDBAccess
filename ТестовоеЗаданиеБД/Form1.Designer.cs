
namespace ТестовоеЗаданиеБД
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataTableView = new System.Windows.Forms.DataGridView();
            this.btnClearSelect = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.Jobs = new System.Windows.Forms.ComboBox();
            this.btnGrand = new System.Windows.Forms.Button();
            this.btnRevoke = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.JobParts = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTableView
            // 
            this.dataTableView.AllowUserToAddRows = false;
            this.dataTableView.AllowUserToDeleteRows = false;
            this.dataTableView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataTableView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataTableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTableView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataTableView.Location = new System.Drawing.Point(0, 78);
            this.dataTableView.Name = "dataTableView";
            this.dataTableView.ReadOnly = true;
            this.dataTableView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataTableView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataTableView.Size = new System.Drawing.Size(916, 383);
            this.dataTableView.TabIndex = 0;
            this.dataTableView.VirtualMode = true;
            this.dataTableView.SelectionChanged += new System.EventHandler(this.dataTableView_SelectionChanged);
            // 
            // btnClearSelect
            // 
            this.btnClearSelect.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnClearSelect.Location = new System.Drawing.Point(12, 12);
            this.btnClearSelect.Name = "btnClearSelect";
            this.btnClearSelect.Size = new System.Drawing.Size(100, 60);
            this.btnClearSelect.TabIndex = 1;
            this.btnClearSelect.Text = "Сбросить фильтры";
            this.btnClearSelect.UseVisualStyleBackColor = true;
            this.btnClearSelect.Click += new System.EventHandler(this.btnClearSelect_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnEdit.Location = new System.Drawing.Point(592, 43);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 25);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Изменить";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnDelete.Location = new System.Drawing.Point(804, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 25);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnInsert.Location = new System.Drawing.Point(592, 12);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(100, 25);
            this.btnInsert.TabIndex = 4;
            this.btnInsert.Text = "Добавить";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // Jobs
            // 
            this.Jobs.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.Jobs.FormattingEnabled = true;
            this.Jobs.Items.AddRange(new object[] {
            "Все",
            "Директор",
            "Руководитель подразделения",
            "Контроллер",
            "Рабочий"});
            this.Jobs.Location = new System.Drawing.Point(234, 12);
            this.Jobs.Name = "Jobs";
            this.Jobs.Size = new System.Drawing.Size(352, 27);
            this.Jobs.TabIndex = 5;
            this.Jobs.Text = "Все";
            this.Jobs.SelectedIndexChanged += new System.EventHandler(this.JobsSelect_SelectedIndexChanged);
            // 
            // btnGrand
            // 
            this.btnGrand.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnGrand.Location = new System.Drawing.Point(698, 12);
            this.btnGrand.Name = "btnGrand";
            this.btnGrand.Size = new System.Drawing.Size(100, 25);
            this.btnGrand.TabIndex = 6;
            this.btnGrand.Text = "Повысить";
            this.btnGrand.UseVisualStyleBackColor = true;
            this.btnGrand.Click += new System.EventHandler(this.btnGrand_Click);
            // 
            // btnRevoke
            // 
            this.btnRevoke.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnRevoke.Location = new System.Drawing.Point(698, 43);
            this.btnRevoke.Name = "btnRevoke";
            this.btnRevoke.Size = new System.Drawing.Size(100, 25);
            this.btnRevoke.TabIndex = 7;
            this.btnRevoke.Text = "Понизить";
            this.btnRevoke.UseVisualStyleBackColor = true;
            this.btnRevoke.Click += new System.EventHandler(this.btnRevoke_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label1.Location = new System.Drawing.Point(118, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Должность:\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label2.Location = new System.Drawing.Point(118, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Подразделение:\r\n";
            // 
            // JobParts
            // 
            this.JobParts.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.JobParts.FormattingEnabled = true;
            this.JobParts.Items.AddRange(new object[] {
            "Все"});
            this.JobParts.Location = new System.Drawing.Point(234, 45);
            this.JobParts.Name = "JobParts";
            this.JobParts.Size = new System.Drawing.Size(352, 27);
            this.JobParts.TabIndex = 10;
            this.JobParts.Text = "Все";
            this.JobParts.SelectedIndexChanged += new System.EventHandler(this.InputJobPart_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 461);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.JobParts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRevoke);
            this.Controls.Add(this.btnGrand);
            this.Controls.Add(this.Jobs);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnClearSelect);
            this.Controls.Add(this.dataTableView);
            this.MaximumSize = new System.Drawing.Size(932, 500);
            this.MinimumSize = new System.Drawing.Size(932, 500);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Основная форма";
            ((System.ComponentModel.ISupportInitialize)(this.dataTableView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataTableView;
        private System.Windows.Forms.Button btnClearSelect;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.ComboBox Jobs;
        private System.Windows.Forms.Button btnGrand;
        private System.Windows.Forms.Button btnRevoke;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox JobParts;
    }
}

