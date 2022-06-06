
namespace ТестовоеЗаданиеБД
{
    partial class EditTable
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GenderInput = new System.Windows.Forms.ComboBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.DateInput = new System.Windows.Forms.DateTimePicker();
            this.NameInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.JobInput = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NameJobPart = new System.Windows.Forms.Label();
            this.InputJobPart = new System.Windows.Forms.TextBox();
            this.InputLeader = new System.Windows.Forms.TextBox();
            this.L6Leader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GenderInput
            // 
            this.GenderInput.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.GenderInput.FormattingEnabled = true;
            this.GenderInput.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.GenderInput.Location = new System.Drawing.Point(263, 128);
            this.GenderInput.Name = "GenderInput";
            this.GenderInput.Size = new System.Drawing.Size(256, 27);
            this.GenderInput.TabIndex = 0;
            this.GenderInput.Text = "Мужской";
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnSend.Location = new System.Drawing.Point(263, 258);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(256, 50);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Добавить или редактировать";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // DateInput
            // 
            this.DateInput.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.DateInput.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateInput.Location = new System.Drawing.Point(263, 96);
            this.DateInput.Name = "DateInput";
            this.DateInput.Size = new System.Drawing.Size(256, 26);
            this.DateInput.TabIndex = 2;
            // 
            // NameInput
            // 
            this.NameInput.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.NameInput.Location = new System.Drawing.Point(263, 64);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(256, 26);
            this.NameInput.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label1.Location = new System.Drawing.Point(76, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "ФИО:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label2.Location = new System.Drawing.Point(76, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Дата рождения:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label3.Location = new System.Drawing.Point(76, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Пол:";
            // 
            // JobInput
            // 
            this.JobInput.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.JobInput.FormattingEnabled = true;
            this.JobInput.Items.AddRange(new object[] {
            "Директор",
            "Руководитель подразделения",
            "Контроллер",
            "Рабочий"});
            this.JobInput.Location = new System.Drawing.Point(263, 161);
            this.JobInput.Name = "JobInput";
            this.JobInput.Size = new System.Drawing.Size(256, 27);
            this.JobInput.TabIndex = 8;
            this.JobInput.Text = "Рабочий";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label4.Location = new System.Drawing.Point(76, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Должность:";
            // 
            // NameJobPart
            // 
            this.NameJobPart.AutoSize = true;
            this.NameJobPart.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.NameJobPart.Location = new System.Drawing.Point(76, 197);
            this.NameJobPart.Name = "NameJobPart";
            this.NameJobPart.Size = new System.Drawing.Size(181, 19);
            this.NameJobPart.TabIndex = 10;
            this.NameJobPart.Text = "Название подразделения:";
            // 
            // InputJobPart
            // 
            this.InputJobPart.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.InputJobPart.Location = new System.Drawing.Point(263, 194);
            this.InputJobPart.Name = "InputJobPart";
            this.InputJobPart.Size = new System.Drawing.Size(256, 26);
            this.InputJobPart.TabIndex = 11;
            // 
            // InputLeader
            // 
            this.InputLeader.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.InputLeader.Location = new System.Drawing.Point(263, 226);
            this.InputLeader.Name = "InputLeader";
            this.InputLeader.Size = new System.Drawing.Size(256, 26);
            this.InputLeader.TabIndex = 13;
            // 
            // L6Leader
            // 
            this.L6Leader.AutoSize = true;
            this.L6Leader.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.L6Leader.Location = new System.Drawing.Point(76, 229);
            this.L6Leader.Name = "L6Leader";
            this.L6Leader.Size = new System.Drawing.Size(143, 19);
            this.L6Leader.TabIndex = 12;
            this.L6Leader.Text = "ФИО руководителя:";
            // 
            // EditTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.InputLeader);
            this.Controls.Add(this.L6Leader);
            this.Controls.Add(this.InputJobPart);
            this.Controls.Add(this.NameJobPart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.JobInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameInput);
            this.Controls.Add(this.DateInput);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.GenderInput);
            this.MaximumSize = new System.Drawing.Size(600, 400);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "EditTable";
            this.Text = "Форма для редактирования";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox GenderInput;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.DateTimePicker DateInput;
        private System.Windows.Forms.TextBox NameInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox JobInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label NameJobPart;
        private System.Windows.Forms.TextBox InputJobPart;
        private System.Windows.Forms.TextBox InputLeader;
        private System.Windows.Forms.Label L6Leader;
    }
}