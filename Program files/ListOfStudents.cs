using System.Collections.Generic;

namespace Lab3
{
    public class ListOfStudents
    {
        private List<Student> ListStud = new List<Student>();
       

        public ListOfStudents()
        {
            ListStud = new List<Student>();
        }

        public void EditStudent(int numb, string surname, string name, string faculty, int diploma, int type)
        {           
            ListStud[numb].name = name;
            ListStud[numb].surname = surname;
            ListStud[numb].faculty = faculty;
            ListStud[numb].diploma = diploma;
            ListStud[numb].type = type;

        }

        public void DeleteStudent(int number)
        {
            ListStud.RemoveAt(number);          
        }

        public void Add(Student newStud)
        {
            ListStud.Add(newStud);
        }
        public void Edit(Student newStud, int index)
        {
            ListStud[index] = newStud;
        }
       
        public Student this[int index]
        {
            get => ListStud[index];
            set => ListStud[index] = value;
        }

        public int Count()
        {
            return ListStud.Count;
        }




    }
}
