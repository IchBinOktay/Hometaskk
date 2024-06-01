using Task15;
using static Task15.degree;

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student();

        student.Add(new Grade("Math", Degree.A));
        student.Add(new Grade("Science", Degree.B));
        student.Add(new Grade("German", Degree.A));


        student.GetAll();

    }
}