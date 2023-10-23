using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetriveStudentData
{
    internal class Student
    {
        static void Main(string[] args)
        {

            string filePath = @"C:\Users\SAI PAVAN KUMAR\source\repos\RetriveStudentData\RetriveStudentData\StudentData.txt"; // Replace with the path to your data file
            if (File.Exists(filePath))
            {
                try
                {
                    string[] lines = File.ReadAllLines(filePath);

                    // Check if the first line contains only whitespace characters
                    if (!string.IsNullOrWhiteSpace(lines[0]))
                    {
                        Console.WriteLine("School Name: " + lines[0]);
                    }
                    else
                    {
                        Console.WriteLine("No school name.");
                        lines = lines.Skip(0).ToArray();
                    }

                    // Display student data
                    for (int i = 1; i < lines.Length; i++)
                    {
                        string[] studentInfo = lines[i].Split(',');
                        if (studentInfo.Length >= 4)
                        { 
                        int studentID = int.Parse(studentInfo[0]);
                        string firstName = studentInfo[1];
                        string lastName = studentInfo[2];
                        string grade = studentInfo[3];

                        Console.WriteLine($"Student ID: {studentID}, Name: {firstName} {lastName}, Grade: {grade}");
                    }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("The file does not exist.");
            }

            Console.ReadLine();
        }
    }
}
