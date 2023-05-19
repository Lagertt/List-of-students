using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Lab3
{
    public partial class EditStudentForm : Form
    {
        private int numb;
        public static Student currentStud = new Student();

        public EditStudentForm(int number, Student currentStud)
        {
            InitializeComponent();
            comboBox_type.SelectedIndex = 0;
            comboBox_type.DropDownStyle = ComboBoxStyle.DropDownList;

            Text = "Редактирование студента"; //сменить заголовок формы
            button_add.Text = "Сохранить изменения";

            EditStudentForm.currentStud = currentStud;
            textBox_surname.Text = currentStud.surname;
            textBox_name.Text = currentStud.surname;
            textBox_faculty.Text = currentStud.faculty;
            textBox_diploma.Text = currentStud.diploma.ToString();
            ChangeType(currentStud.type);

            comboBox_type.SelectedIndex = currentStud.type;

            numb = number;
        }

        public EditStudentForm()
        {
            InitializeComponent();
            currentStud = new Student();
            comboBox_type.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_type.SelectedIndex = 0;
        }

        private void Button_add_Click(object sender, EventArgs e)
        {
            bool isFill = true;

            foreach (TextBox tb in Controls.OfType<TextBox>())
            {
                if (tb.Text == "" && tb.Visible == true)
                {
                    isFill = false;
                    tb.BackColor = Color.MistyRose;
                }
                else
                {
                    tb.BackColor = Color.White;
                }
            }

            int diplom = 0;
            if (textBox_diploma.Visible)
            {                
                try
                {
                    diplom = int.Parse(textBox_diploma.Text);
                    if (diplom < 1)
                        throw new Exception();
                }
                catch
                {
                    isFill = false;
                    textBox_diploma.BackColor = Color.MistyRose;
                }
            }

            if (isFill)
            {
                currentStud.name = textBox_name.Text;
                currentStud.surname = textBox_surname.Text;
                currentStud.faculty = textBox_faculty.Text;
                currentStud.diploma = diplom;
                currentStud.type = comboBox_type.SelectedIndex;

                DialogResult = DialogResult.OK;
                Files.isUpdated = true;
                Close();
            }
            else
                DialogResult = DialogResult.None;

        }

        private void ChangeType(int type)
        {
            switch (type)
            {
                case 0:
                    textBox_diploma.Visible = true;
                    label_diploma.Visible = true;
                    break;
                case 1:
                    textBox_diploma.Visible = false;
                    label_diploma.Visible = false;
                    break;
            }

        }

        private void comboBox_type_SelectedIndexChenge(object sender, EventArgs e)
        {
            ChangeType(comboBox_type.SelectedIndex);
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
