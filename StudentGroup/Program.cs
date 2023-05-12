using System.Runtime.CompilerServices;

namespace StudentGroup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("StudentGroup");

            /*
            Make a new console application called StudentGroup

            Make 2 arrays called studentsG1 and studentsG2 and fill them with 5 student names (strings).
            Get a number from the console between 1 and 2 and print the students from that group in the console.
            
            Ex: studentsG1 ["Zdravko", "Petko", "Stanko", "Branko", "Trajko"]
                Test Data:
                Enter student group: ( there are 1 and 2 )
                    1

                Expected Output:
                    The Students in G1 are:
                        Zdravko
                        Petko
                        Stanko
                        Branko
                        Trajko
            */

            string[] studentsG1 = new string[5] { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
            string[] studentsG2 = new string[5] { "Zhaklina", "Ivana", "Jasmina", "Florina", "Sonja" };

            Console.WriteLine("To see group one press 1, to see group two press 2.");
            string userInput = Console.ReadLine();
            if (!int.TryParse(userInput, out int input))
            {
                Console.WriteLine("Wrong input!");
                return;
            }
            

            if(input == 1)
            {
                Console.Write("Student Group 1: ");
                foreach (string student in studentsG1)
                {
                    Console.Write(student + " ");
                }
            } 
            else if(input == 2)
            {
                Console.Write("\nStudents Group 2: ");
                foreach (string student in studentsG2)
                {
                    Console.Write(student + " ");
                }
            }
            else
            {
                Console.WriteLine("Error!");
            }
            
        }
    }
}