
namespace Lab3
{
    partial class EditStudentForm
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
            this.button_add = new System.Windows.Forms.Button();
            this.textBox_faculty = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_surname = new System.Windows.Forms.TextBox();
            this.label_faculty = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label_surname = new System.Windows.Forms.Label();
            this.textBox_diploma = new System.Windows.Forms.TextBox();
            this.label_diploma = new System.Windows.Forms.Label();
            this.comboBox_type = new System.Windows.Forms.ComboBox();
            this.label_type = new System.Windows.Forms.Label();
            this.button_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(74)))), ((int)(((byte)(226)))));
            this.button_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_add.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_add.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_add.ForeColor = System.Drawing.Color.White;
            this.button_add.Location = new System.Drawing.Point(449, 236);
            this.button_add.Margin = new System.Windows.Forms.Padding(4);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(230, 57);
            this.button_add.TabIndex = 25;
            this.button_add.Text = "Добавить";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.Button_add_Click);
            // 
            // textBox_faculty
            // 
            this.textBox_faculty.BackColor = System.Drawing.Color.White;
            this.textBox_faculty.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_faculty.Location = new System.Drawing.Point(194, 119);
            this.textBox_faculty.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_faculty.Name = "textBox_faculty";
            this.textBox_faculty.Size = new System.Drawing.Size(485, 32);
            this.textBox_faculty.TabIndex = 20;
            // 
            // textBox_name
            // 
            this.textBox_name.BackColor = System.Drawing.Color.White;
            this.textBox_name.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_name.Location = new System.Drawing.Point(194, 68);
            this.textBox_name.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(485, 32);
            this.textBox_name.TabIndex = 18;
            // 
            // textBox_surname
            // 
            this.textBox_surname.BackColor = System.Drawing.Color.White;
            this.textBox_surname.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_surname.Location = new System.Drawing.Point(194, 13);
            this.textBox_surname.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_surname.Name = "textBox_surname";
            this.textBox_surname.Size = new System.Drawing.Size(485, 32);
            this.textBox_surname.TabIndex = 16;
            // 
            // label_faculty
            // 
            this.label_faculty.AutoSize = true;
            this.label_faculty.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_faculty.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_faculty.Location = new System.Drawing.Point(77, 121);
            this.label_faculty.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label_faculty.Name = "label_faculty";
            this.label_faculty.Size = new System.Drawing.Size(108, 24);
            this.label_faculty.TabIndex = 19;
            this.label_faculty.Text = "Факультет";
            this.label_faculty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_name.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_name.Location = new System.Drawing.Point(125, 70);
            this.label_name.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(50, 24);
            this.label_name.TabIndex = 17;
            this.label_name.Text = "Имя";
            this.label_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_surname
            // 
            this.label_surname.AutoSize = true;
            this.label_surname.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_surname.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_surname.Location = new System.Drawing.Point(87, 15);
            this.label_surname.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label_surname.Name = "label_surname";
            this.label_surname.Size = new System.Drawing.Size(98, 24);
            this.label_surname.TabIndex = 15;
            this.label_surname.Text = "Фамилия";
            this.label_surname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_diploma
            // 
            this.textBox_diploma.BackColor = System.Drawing.Color.White;
            this.textBox_diploma.Location = new System.Drawing.Point(194, 176);
            this.textBox_diploma.Name = "textBox_diploma";
            this.textBox_diploma.Size = new System.Drawing.Size(485, 32);
            this.textBox_diploma.TabIndex = 22;
            // 
            // label_diploma
            // 
            this.label_diploma.AutoSize = true;
            this.label_diploma.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_diploma.Location = new System.Drawing.Point(36, 179);
            this.label_diploma.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_diploma.Name = "label_diploma";
            this.label_diploma.Size = new System.Drawing.Size(162, 24);
            this.label_diploma.TabIndex = 21;
            this.label_diploma.Text = "Номер диплома";
            this.label_diploma.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox_type
            // 
            this.comboBox_type.FormattingEnabled = true;
            this.comboBox_type.ItemHeight = 24;
            this.comboBox_type.Items.AddRange(new object[] {
            "Магистр",
            "Бакалавр"});
            this.comboBox_type.Location = new System.Drawing.Point(194, 249);
            this.comboBox_type.Name = "comboBox_type";
            this.comboBox_type.Size = new System.Drawing.Size(218, 32);
            this.comboBox_type.TabIndex = 24;
            this.comboBox_type.SelectedIndexChanged += new System.EventHandler(this.comboBox_type_SelectedIndexChenge);
            // 
            // label_type
            // 
            this.label_type.AutoSize = true;
            this.label_type.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_type.Location = new System.Drawing.Point(53, 252);
            this.label_type.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_type.Name = "label_type";
            this.label_type.Size = new System.Drawing.Size(134, 24);
            this.label_type.TabIndex = 23;
            this.label_type.Text = "Тип студента";
            this.label_type.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_cancel
            // 
            this.button_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(74)))), ((int)(((byte)(226)))));
            this.button_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_cancel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_cancel.ForeColor = System.Drawing.Color.White;
            this.button_cancel.Location = new System.Drawing.Point(449, 321);
            this.button_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(230, 57);
            this.button_cancel.TabIndex = 26;
            this.button_cancel.Text = "Отмена";
            this.button_cancel.UseVisualStyleBackColor = false;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // EditStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 399);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.label_type);
            this.Controls.Add(this.comboBox_type);
            this.Controls.Add(this.textBox_diploma);
            this.Controls.Add(this.label_diploma);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.textBox_faculty);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.textBox_surname);
            this.Controls.Add(this.label_faculty);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label_surname);
            this.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "EditStudentForm";
            this.Text = "Добавление студента";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.TextBox textBox_faculty;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_surname;
        private System.Windows.Forms.Label label_faculty;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_surname;
        private System.Windows.Forms.TextBox textBox_diploma;
        private System.Windows.Forms.Label label_diploma;
        private System.Windows.Forms.ComboBox comboBox_type;
        private System.Windows.Forms.Label label_type;
        private System.Windows.Forms.Button button_cancel;
    }
}