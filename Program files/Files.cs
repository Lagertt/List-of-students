using System.Windows.Forms;
using System;
using System.IO;
using System.Xml.Serialization;


namespace Lab3
{
    static class Files
    {
        public static bool isUpdated = false; //были ли изменения в файле
        public static string path = ""; //путь до файла
        public static ListOfStudents list;

        public static DialogResult SaveOrNo()
        {
            DialogResult result = DialogResult.Cancel;
            if (isUpdated)
            {
                result = MessageBox.Show("Сохранить изменения?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Save();// Сохраняем
                }                
            }
            return result;
        }

        public static void SaveOrNo(FormClosingEventArgs e)
        {
            if (isUpdated)
            {
                DialogResult result = MessageBox.Show("Сохранить изменения?", "Закрытие приложения", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Save();// Сохраняем
                }
                else if (result == DialogResult.No)
                {
                    e.Cancel = false; //Не сохраняем
                }
                else e.Cancel = true;//Отменяем действие
            }
        }

        public static void Save()
        {
            if (path != "")
            {
                SerializeList(path);
            }
            else
                SaveAs();
            isUpdated = false;
        }

        public static void SaveAs()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Select File";
            sfd.Filter = "Xml File (*.xml*)|*.xml";
            sfd.DefaultExt = "xml";
            sfd.ShowDialog();
            path = sfd.FileName;

            if (path != "")
                Save();
        }

        public static DialogResult CreateFile()
        {
            DialogResult result = DialogResult.Yes;
            if (isUpdated)
            {
                result = SaveOrNo();                
            }

            if (result != DialogResult.Cancel)
            {
                new ListOfStudents();
                path = "";
                isUpdated = false;
            }

            return result;
        }

        public static DialogResult OpenFile(ListOfStudents list)
        {
            Files.list = list;

            DialogResult result = DialogResult.Yes;
            if (isUpdated)
                result = SaveOrNo();

            if (result != DialogResult.Cancel)
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Title = "Select File";
                ofd.Filter = "All files (*.*)|*.*|Xml File (*.xml*)|*.xml";
                ofd.FilterIndex = 2;
                ofd.ShowDialog();
                path = ofd.FileName;

                if (path != "")
                    ReadFromFile(list);
            }

            return result;
        }

        public static void ReadFromFile(ListOfStudents list)
        {
            DeserializeList(path);
            isUpdated = false;            
        }

        public static void SerializeList(string path)
        {
            // передаем в конструктор тип класса Person
            XmlSerializer formatter = new XmlSerializer(typeof(ListOfStudents));

            // получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                formatter.Serialize(fs, list);
            }
        }

        public static void DeserializeList(string path)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(ListOfStudents));

            // десериализуем объект
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                list = formatter.Deserialize(fs) as ListOfStudents;
            }
        }

    }
}
