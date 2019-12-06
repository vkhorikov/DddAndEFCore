using System;
using System.Collections.Generic;

namespace App
{
    public class Student
    {
        public long Id { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public Course FavoriteCourse { get; private set; }
        public ICollection<Enrollment> Enrollments { get; private set; }

        private Student()
        {
        }

        public Student(string name, string email, Course favoriteCourse)
            : this()
        {
            Name = name;
            Email = email;
            FavoriteCourse = favoriteCourse;
        }

        public void StartProject()
        {
            if (FavoriteCourse == null)
                return;

            // Start a new project related to the favorite course
        }

        public void AddEnrollment(Enrollment enrollment)
        {
            if (Enrollments.Count >= 5)
                throw new Exception();

            // add enrollment
        }
    }
}
