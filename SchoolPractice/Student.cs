﻿using System;

// Start working here with your Student class.
// To instantiate the Student class, add your code to the Main method in Program

namespace SchoolPractice
{
    public class Student
    {
        private static int nextStudentId = 1;
        public string Name { get; set; }
        public int StudentId { get; set; }
        public int NumberOfCredits { get; set; } = 0;
        public double Gpa { get; set; } = 0.0;

        public Student(string name, int studentId, int numberOfCredits, double gpa)
        {
            Name = name;
            StudentId = studentId;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }

        public Student(string name, int studentId): this(name, studentId, 0, 0) { }
        public Student(string name): this(name, nextStudentId)
        {
            nextStudentId++;
        }

        public string GetGradeLevel(int credits)
        {
            if (credits <= 29)
            {
                return "freshman";
            }
            else if (credits <= 59)
            {
                return "sophomore";
            }
            else if (credits <= 89)
            {
                return "junior";
            }
            else
            {
                return "senior";
            }
        }

        public void AddGrade(int courseCredits, double grade)
        {
            // Update the appropriate properties: NumberOfCredits, Gpa
            double totalQualityScore = Gpa * NumberOfCredits;
            totalQualityScore += courseCredits * grade;
            NumberOfCredits += courseCredits;
            Gpa = totalQualityScore / NumberOfCredits;
        }

        public override string ToString()
        {
            return Name + " (Credits: " + NumberOfCredits + ", GPA: " + Gpa + ")";
        }

        public override bool Equals(object obj)
        {
            if (obj == this)
            {
                return true;
            }

            if (obj == null)
            {
                return false;
            }

            if (obj.GetType() != GetType())
            {
                return false;
            }

            Student studentObj = obj as Student;
            return StudentId == studentObj.StudentId;
        }
    }

}
