using Project;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

////TASK: ● Create a class Student that has properties: Name, Academy and Group
////● Create an array with 5 new Students(objects)  ● The user should enter a name and the user information
//// should be displayed in the console if a user by that name exists
//// ● If there is no such user it should show an error message


Student[] arrOfStudents = { new Student("Viktor", "SEDC", "G2"), new Student("Marko", "Brainster", "G2"), new Student("Maria", "Semos", "G5"), new Student("Bojan", "Finki", "G1"), new Student("Kristina", "SEDC", "G1") };

Console.WriteLine("Search for a student, enter his name:");
string nameSearch = Console.ReadLine().ToLower();

bool studentFound = false;

foreach (var item in arrOfStudents)
{
    if (nameSearch == item.Name.ToLower())
    {
        Console.WriteLine(item.StudentInfo());
        studentFound = true;
        break;
    }
}

if (!studentFound)
{
    Console.WriteLine("ERROR: No such a student was found!");
}
