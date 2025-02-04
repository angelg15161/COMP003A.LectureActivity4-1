// Author: Angel Gomez
// Course: COMP003A
// Faculty: Jonathan Cruz
// Purpose: Calculate average grades using arrays and lists in C#
namespace COMP003A.LectureActivity4_1;

class Program
{
    static void Main(string[] args)
    {
        // Declare array for 5 grades 
        int[] grades = new int[5];
        
        // Collect, validate, then store the grades 
        for (int i = 0; i < grades.Length; i++)
        {
            int grade = -1; // Initialize with an invalid value to ensure validation starts 
            while (grade < 0 || grade > 100)
            {
                Console.Write($"Enter grade for student {i + 1} (0-100): ");
                if (int.TryParse(Console.ReadLine(), out grade))
                {
                    if (grade >= 0 && grade <= 100)
                    {
                        grades[i] = grade;
                    }
                    else
                    {
                        Console.WriteLine("Grade must be between 0 and 100.");
                    }
                }
                else
                {
                    Console.Write("Invalid input. Please enter a valid number.");
                    grade = -1; // Reset grade to an invalid value to re-enter the loop 
                }
            }
        }
        
        // Calculate the average grades 
        double sum = 0;
        for (int i = 0; i < grades.Length; i++)
        {
            sum += grades[i]; // Add the current grade to the total sum for averaging 
        }
        double average = sum / grades.Length;
        
        
        // Display the grades and average 
        Console.WriteLine("\nGrades:");
        foreach (int grade in grades)
        {
            Console.WriteLine(grade);
        }
        Console.WriteLine($"Average: {average:F2}");
        
        // Declare a list to store student names
        List<string> studentNames = new List<string>();
        
        // Collect student names 
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Enter name for student {i + 1}: ");
            studentNames.Add(Console.ReadLine());   // Add the entered name to the list of student names 
        }
        
        // Display the student names 
        Console.WriteLine("\nStudent Names:");
        for (int i = 0; i < studentNames.Count; i++)
        {
            Console.WriteLine($"Student {i + 1}: {studentNames[i]}");   // Display each student name with their index
        }
    }
}