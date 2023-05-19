
namespace Lab3
{
    public class Student
    {
        public string surname;
        public string name;
        public string faculty;
        public int diploma;
        public int type;

        /*0 - выпускник
        1 - обучающийся*/

        public Student(string Surname, string Name, string Faculty, int Diploma, int Type)
        {
            surname = Surname;
            name = Name;
            faculty = Faculty;
            diploma = Diploma;

            type = Type;
        }
        
        //конструктор без параметров для сериализации
        public Student() { }

                
    }
}
