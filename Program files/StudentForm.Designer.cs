
namespace Lab3
{
    partial class StudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            this.label_surname = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label_faculty = new System.Windows.Forms.Label();
            this.textBox_surname = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_faculty = new System.Windows.Forms.TextBox();
            this.Button_prev = new System.Windows.Forms.Button();
            this.Button_next = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.File_MenuIItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Create_File_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Open_File_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.Save_File_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAs_File_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Exit_File_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Show_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Prev_Show_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Next_Show_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.InBegin_Show_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.InEnd_Show_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Student_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Add_Student_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Edit_Item_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Delete_Item_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.label_number = new System.Windows.Forms.Label();
            this.label_diploma = new System.Windows.Forms.Label();
            this.textBox_diploma = new System.Windows.Forms.TextBox();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_surname
            // 
            this.label_surname.AutoSize = true;
            this.label_surname.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_surname.Location = new System.Drawing.Point(88, 92);
            this.label_surname.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_surname.Name = "label_surname";
            this.label_surname.Size = new System.Drawing.Size(98, 24);
            this.label_surname.TabIndex = 0;
            this.label_surname.Text = "Фамилия";
            this.label_surname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_name.Location = new System.Drawing.Point(125, 146);
            this.label_name.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(50, 24);
            this.label_name.TabIndex = 2;
            this.label_name.Text = "Имя";
            this.label_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_faculty
            // 
            this.label_faculty.AutoSize = true;
            this.label_faculty.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_faculty.Location = new System.Drawing.Point(79, 199);
            this.label_faculty.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_faculty.Name = "label_faculty";
            this.label_faculty.Size = new System.Drawing.Size(108, 24);
            this.label_faculty.TabIndex = 4;
            this.label_faculty.Text = "Факультет";
            this.label_faculty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_surname
            // 
            this.textBox_surname.BackColor = System.Drawing.Color.White;
            this.textBox_surname.Location = new System.Drawing.Point(204, 90);
            this.textBox_surname.Name = "textBox_surname";
            this.textBox_surname.Size = new System.Drawing.Size(485, 32);
            this.textBox_surname.TabIndex = 1;
            // 
            // textBox_name
            // 
            this.textBox_name.BackColor = System.Drawing.Color.White;
            this.textBox_name.Location = new System.Drawing.Point(204, 143);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(485, 32);
            this.textBox_name.TabIndex = 3;
            // 
            // textBox_faculty
            // 
            this.textBox_faculty.BackColor = System.Drawing.Color.White;
            this.textBox_faculty.Location = new System.Drawing.Point(204, 197);
            this.textBox_faculty.Name = "textBox_faculty";
            this.textBox_faculty.Size = new System.Drawing.Size(485, 32);
            this.textBox_faculty.TabIndex = 5;
            // 
            // Button_prev
            // 
            this.Button_prev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(74)))), ((int)(((byte)(226)))));
            this.Button_prev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_prev.ForeColor = System.Drawing.Color.White;
            this.Button_prev.Location = new System.Drawing.Point(204, 313);
            this.Button_prev.Name = "Button_prev";
            this.Button_prev.Size = new System.Drawing.Size(230, 57);
            this.Button_prev.TabIndex = 8;
            this.Button_prev.Text = "Предыдущий";
            this.Button_prev.UseVisualStyleBackColor = false;
            this.Button_prev.Click += new System.EventHandler(this.Button_prev_Click);
            // 
            // Button_next
            // 
            this.Button_next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(74)))), ((int)(((byte)(226)))));
            this.Button_next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_next.ForeColor = System.Drawing.Color.White;
            this.Button_next.Location = new System.Drawing.Point(459, 313);
            this.Button_next.Name = "Button_next";
            this.Button_next.Size = new System.Drawing.Size(230, 57);
            this.Button_next.TabIndex = 9;
            this.Button_next.Text = "Следующий";
            this.Button_next.UseVisualStyleBackColor = false;
            this.Button_next.Click += new System.EventHandler(this.Button_next_Click);
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File_MenuIItem,
            this.Show_Menu,
            this.Student_Menu});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(782, 28);
            this.menu.TabIndex = 13;
            this.menu.Text = "menuStrip1";
            // 
            // File_MenuIItem
            // 
            this.File_MenuIItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Create_File_Menu,
            this.Open_File_Menu,
            this.toolStripSeparator,
            this.Save_File_Menu,
            this.SaveAs_File_Menu,
            this.toolStripSeparator1,
            this.Exit_File_Menu});
            this.File_MenuIItem.Name = "File_MenuIItem";
            this.File_MenuIItem.Size = new System.Drawing.Size(59, 24);
            this.File_MenuIItem.Text = "&Файл";
            // 
            // Create_File_Menu
            // 
            this.Create_File_Menu.Image = ((System.Drawing.Image)(resources.GetObject("Create_File_Menu.Image")));
            this.Create_File_Menu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Create_File_Menu.Name = "Create_File_Menu";
            this.Create_File_Menu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.Create_File_Menu.Size = new System.Drawing.Size(300, 26);
            this.Create_File_Menu.Text = "&Создать список";
            this.Create_File_Menu.Click += new System.EventHandler(this.Create_File_Menu_Click);
            // 
            // Open_File_Menu
            // 
            this.Open_File_Menu.Image = ((System.Drawing.Image)(resources.GetObject("Open_File_Menu.Image")));
            this.Open_File_Menu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Open_File_Menu.Name = "Open_File_Menu";
            this.Open_File_Menu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.Open_File_Menu.Size = new System.Drawing.Size(300, 26);
            this.Open_File_Menu.Text = "&Открыть список";
            this.Open_File_Menu.Click += new System.EventHandler(this.Open_File_Menu_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(297, 6);
            // 
            // Save_File_Menu
            // 
            this.Save_File_Menu.Image = ((System.Drawing.Image)(resources.GetObject("Save_File_Menu.Image")));
            this.Save_File_Menu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Save_File_Menu.Name = "Save_File_Menu";
            this.Save_File_Menu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.Save_File_Menu.Size = new System.Drawing.Size(300, 26);
            this.Save_File_Menu.Text = "&Сохранить";
            this.Save_File_Menu.Click += new System.EventHandler(this.Save_File_Menu_Click);
            // 
            // SaveAs_File_Menu
            // 
            this.SaveAs_File_Menu.Name = "SaveAs_File_Menu";
            this.SaveAs_File_Menu.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.SaveAs_File_Menu.Size = new System.Drawing.Size(300, 26);
            this.SaveAs_File_Menu.Text = "Сохранить &как";
            this.SaveAs_File_Menu.Click += new System.EventHandler(this.SaveAs_File_Menu_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(297, 6);
            // 
            // Exit_File_Menu
            // 
            this.Exit_File_Menu.Name = "Exit_File_Menu";
            this.Exit_File_Menu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.Exit_File_Menu.Size = new System.Drawing.Size(300, 26);
            this.Exit_File_Menu.Text = "Выход";
            this.Exit_File_Menu.Click += new System.EventHandler(this.Exit_File_Menu_Click);
            // 
            // Show_Menu
            // 
            this.Show_Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Prev_Show_Menu,
            this.Next_Show_Menu,
            this.toolStripSeparator3,
            this.InBegin_Show_Menu,
            this.InEnd_Show_Menu});
            this.Show_Menu.Name = "Show_Menu";
            this.Show_Menu.Size = new System.Drawing.Size(94, 24);
            this.Show_Menu.Text = "Просмотр";
            // 
            // Prev_Show_Menu
            // 
            this.Prev_Show_Menu.Name = "Prev_Show_Menu";
            this.Prev_Show_Menu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Left)));
            this.Prev_Show_Menu.Size = new System.Drawing.Size(333, 26);
            this.Prev_Show_Menu.Text = "Предыдущий";
            this.Prev_Show_Menu.Click += new System.EventHandler(this.Button_prev_Click);
            // 
            // Next_Show_Menu
            // 
            this.Next_Show_Menu.Name = "Next_Show_Menu";
            this.Next_Show_Menu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Right)));
            this.Next_Show_Menu.Size = new System.Drawing.Size(333, 26);
            this.Next_Show_Menu.Text = "Следующий";
            this.Next_Show_Menu.Click += new System.EventHandler(this.Button_next_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(330, 6);
            // 
            // InBegin_Show_Menu
            // 
            this.InBegin_Show_Menu.Name = "InBegin_Show_Menu";
            this.InBegin_Show_Menu.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Left)));
            this.InBegin_Show_Menu.Size = new System.Drawing.Size(333, 26);
            this.InBegin_Show_Menu.Text = "В начало списка";
            this.InBegin_Show_Menu.Click += new System.EventHandler(this.InBegin_Show_Menu_Click);
            // 
            // InEnd_Show_Menu
            // 
            this.InEnd_Show_Menu.Name = "InEnd_Show_Menu";
            this.InEnd_Show_Menu.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Right)));
            this.InEnd_Show_Menu.Size = new System.Drawing.Size(333, 26);
            this.InEnd_Show_Menu.Text = "В конец списка";
            this.InEnd_Show_Menu.Click += new System.EventHandler(this.InEnd_Show_Menu_Click);
            // 
            // Student_Menu
            // 
            this.Student_Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Add_Student_Menu,
            this.Edit_Item_Menu,
            this.Delete_Item_Menu});
            this.Student_Menu.Name = "Student_Menu";
            this.Student_Menu.Size = new System.Drawing.Size(76, 24);
            this.Student_Menu.Text = "Студент";
            // 
            // Add_Student_Menu
            // 
            this.Add_Student_Menu.Name = "Add_Student_Menu";
            this.Add_Student_Menu.ShortcutKeys = System.Windows.Forms.Keys.Insert;
            this.Add_Student_Menu.Size = new System.Drawing.Size(254, 26);
            this.Add_Student_Menu.Text = "Добавить";
            this.Add_Student_Menu.Click += new System.EventHandler(this.Add_Student_Menu_Click);
            // 
            // Edit_Item_Menu
            // 
            this.Edit_Item_Menu.Name = "Edit_Item_Menu";
            this.Edit_Item_Menu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.Edit_Item_Menu.Size = new System.Drawing.Size(254, 26);
            this.Edit_Item_Menu.Text = "Редактировать";
            this.Edit_Item_Menu.Click += new System.EventHandler(this.Edit_Item_Menu_Click);
            // 
            // Delete_Item_Menu
            // 
            this.Delete_Item_Menu.Name = "Delete_Item_Menu";
            this.Delete_Item_Menu.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.Delete_Item_Menu.Size = new System.Drawing.Size(254, 26);
            this.Delete_Item_Menu.Text = "Удалить";
            this.Delete_Item_Menu.Click += new System.EventHandler(this.Delete_Item_Menu_Click);
            // 
            // label_number
            // 
            this.label_number.AutoSize = true;
            this.label_number.Location = new System.Drawing.Point(414, 50);
            this.label_number.Name = "label_number";
            this.label_number.Size = new System.Drawing.Size(64, 24);
            this.label_number.TabIndex = 14;
            this.label_number.Text = "0 из 0";
            this.label_number.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_diploma
            // 
            this.label_diploma.AutoSize = true;
            this.label_diploma.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_diploma.Location = new System.Drawing.Point(37, 258);
            this.label_diploma.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_diploma.Name = "label_diploma";
            this.label_diploma.Size = new System.Drawing.Size(162, 24);
            this.label_diploma.TabIndex = 6;
            this.label_diploma.Text = "Номер диплома";
            this.label_diploma.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_diploma
            // 
            this.textBox_diploma.BackColor = System.Drawing.Color.White;
            this.textBox_diploma.Location = new System.Drawing.Point(204, 255);
            this.textBox_diploma.Name = "textBox_diploma";
            this.textBox_diploma.Size = new System.Drawing.Size(485, 32);
            this.textBox_diploma.TabIndex = 7;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(782, 414);
            this.Controls.Add(this.textBox_diploma);
            this.Controls.Add(this.label_diploma);
            this.Controls.Add(this.label_number);
            this.Controls.Add(this.Button_next);
            this.Controls.Add(this.Button_prev);
            this.Controls.Add(this.textBox_faculty);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.textBox_surname);
            this.Controls.Add(this.label_faculty);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label_surname);
            this.Controls.Add(this.menu);
            this.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menu;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "StudentForm";
            this.Text = "БД \"Студенты\"";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StudentForm_FormClosing);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_surname;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_faculty;
        private System.Windows.Forms.Button Button_prev;
        private System.Windows.Forms.Button Button_next;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem File_MenuIItem;
        private System.Windows.Forms.ToolStripMenuItem Create_File_Menu;
        private System.Windows.Forms.ToolStripMenuItem Open_File_Menu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem Save_File_Menu;
        private System.Windows.Forms.ToolStripMenuItem SaveAs_File_Menu;
        private System.Windows.Forms.ToolStripMenuItem Show_Menu;
        private System.Windows.Forms.ToolStripMenuItem Student_Menu;
        private System.Windows.Forms.ToolStripMenuItem Prev_Show_Menu;
        private System.Windows.Forms.ToolStripMenuItem Next_Show_Menu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem InBegin_Show_Menu;
        private System.Windows.Forms.ToolStripMenuItem InEnd_Show_Menu;
        private System.Windows.Forms.ToolStripMenuItem Add_Student_Menu;
        private System.Windows.Forms.ToolStripMenuItem Delete_Item_Menu;
        private System.Windows.Forms.Label label_number;
        private System.Windows.Forms.Label label_surname;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_faculty;
        private System.Windows.Forms.ToolStripMenuItem Edit_Item_Menu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem Exit_File_Menu;
        private System.Windows.Forms.Label label_diploma;
        private System.Windows.Forms.TextBox textBox_diploma;
    }
}

