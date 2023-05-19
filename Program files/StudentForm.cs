using System;
using System.Linq;
using System.Windows.Forms;

namespace Lab3
{ 
    public partial class StudentForm : Form
    {
        private static int CurrentNumber = -1; //номер текущего студента
        private ListOfStudents ListStud = new ListOfStudents();

        public StudentForm()
        {
            InitializeComponent();

            CheckBottons();            

            foreach (TextBox tb in Controls.OfType<TextBox>())
            {
                tb.ReadOnly = true;
            }           

        }

        //////////////////////////////////////////////////////////////
        ////////////////ПЕРЕКЛЮЧЕНИЕ НАЗАД/ВПЕРЁД/////////////////////
        //////////////////////////////////////////////////////////////

        private void Button_prev_Click(object sender, EventArgs e)
        {
            CurrentNumber--;
            FillForm();
        }

        private void Button_next_Click(object sender, EventArgs e)
        {
            CurrentNumber++;
            FillForm();
        }

        private void InBegin_Show_Menu_Click(object sender, EventArgs e)
        {
            CurrentNumber = 0;
            FillForm();                
        }

        private void InEnd_Show_Menu_Click(object sender, EventArgs e)
        {
            CurrentNumber = ListStud.Count() - 1;
            FillForm();                
        }


        //////////////////////////////////////////////////////////////
        ///////////////////////РАБОТА С ФАЙЛАМИ///////////////////////
        //////////////////////////////////////////////////////////////

        private void Open_File_Menu_Click(object sender, EventArgs e)
        {            
            DialogResult result = Files.OpenFile(ListStud);

            if (result != DialogResult.Cancel)
            {
                if (ListStud.Count() == 0) //открыт пустой файл
                    CurrentNumber = -1;
                else
                    CurrentNumber = 0;

                FillForm();
            }
            
        }

        private void Create_File_Menu_Click(object sender, EventArgs e)
        {
            DialogResult result = Files.CreateFile();
            if (result != DialogResult.Cancel)
            {
                CurrentNumber = -1;

                label_number.Text = "0 из 0";
                foreach (TextBox tb in Controls.OfType<TextBox>())
                {
                    tb.Clear();
                }
            }                
            
        }

        private void Save_File_Menu_Click(object sender, EventArgs e)
        {
            Files.Save();
        }

        private void SaveAs_File_Menu_Click(object sender, EventArgs e)
        {
            Files.SaveAs();
        }

        //////////////////////////////////////////////////////////////
        ////////////////РАБОТА СО СПИСКОМ СТУДЕНТОВ///////////////////
        //////////////////////////////////////////////////////////////

        private void Add_Student_Menu_Click(object sender, EventArgs e)
        {
            int beginCount = ListStud.Count(); //количество студентов до открытия формы
            
            EditStudentForm EditForm = new EditStudentForm();
            DialogResult result = EditForm.ShowDialog();

            if (result == DialogResult.OK) //количество изменилось
            {
                Student newStud = EditStudentForm.currentStud;
                ListStud.Add(newStud);
                if (CurrentNumber == -1) //первый студент
                    CurrentNumber++;
                FillForm();
            }

        }

        private void Delete_Item_Menu_Click(object sender, EventArgs e)
        {
            ListStud.DeleteStudent(CurrentNumber);

            //удалён последний элемент
            if (CurrentNumber == ListStud.Count())
                CurrentNumber = ListStud.Count() - 1;

            Files.isUpdated = true;
            FillForm();

        }

        private void Edit_Item_Menu_Click(object sender, EventArgs e)
        {
            Student cur_stud = ListStud[CurrentNumber];
            EditStudentForm EditForm = new EditStudentForm(CurrentNumber, cur_stud);
            EditForm.ShowDialog();

            if (EditForm.DialogResult == DialogResult.OK)
            {
                ListStud[CurrentNumber] = EditStudentForm.currentStud;
            }

            FillForm();
        }

        //////////////////////////////////////////////////////////////
        ////////////////////////ВЫХОД ИЗ ФОРМЫ////////////////////////
        //////////////////////////////////////////////////////////////

        private void StudentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Files.SaveOrNo(e);
        }

        private void Exit_File_Menu_Click(object sender, EventArgs e)
        {
            Close();
        }

        //////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////              

        private void FillForm()
        {
            label_number.Text = $"{CurrentNumber + 1} из {ListStud.Count()}";

            CheckBottons();

            //пустой список
            if (CurrentNumber == -1)
            {
                if (Files.path == "")
                    Files.isUpdated = false;

                foreach (TextBox tb in Controls.OfType<TextBox>())
                {
                    tb.Text = "";
                }
            }
            else
            {
                Student currentStud = ListStud[CurrentNumber];

                textBox_surname.Text = currentStud.surname;
                textBox_name.Text = currentStud.name;
                textBox_faculty.Text = currentStud.faculty;

                if (currentStud.type == 0)
                {
                    textBox_diploma.Visible = true;
                    label_diploma.Visible = true;
                    textBox_diploma.Text = currentStud.diploma.ToString();
                }
                else
                {
                    textBox_diploma.Visible = false;
                    label_diploma.Visible = false;
                }
                                
            }
        }

        private void CheckBottons()
        {
            //переход назад по списку
            if (CurrentNumber <= 0)
            {
                Button_prev.Enabled = false;
                Prev_Show_Menu.Enabled = false;
                InBegin_Show_Menu.Enabled = false;
            }
            else
            {
                Button_prev.Enabled = true;
                Prev_Show_Menu.Enabled = true;
                InBegin_Show_Menu.Enabled = true;
            }

            //переход вперёд по списку
            if (CurrentNumber == ListStud.Count() - 1)
            {
                Button_next.Enabled = false;
                Next_Show_Menu.Enabled = false;
                InEnd_Show_Menu.Enabled = false;
            }
            else
            {
                Button_next.Enabled = true;
                Next_Show_Menu.Enabled = true;
                InEnd_Show_Menu.Enabled = true;
            }

            //пустой список
            if (CurrentNumber == -1)
            {
                Delete_Item_Menu.Enabled = false;
                Edit_Item_Menu.Enabled = false;
            }
            else
            {
                Delete_Item_Menu.Enabled = true;
                Edit_Item_Menu.Enabled = true;
            }
        }

    }
}
