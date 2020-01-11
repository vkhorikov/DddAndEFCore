using System.Collections.Generic;
using System.Linq;

namespace App
{
    public class Student : Entity
    {
        public string Name { get; }
        public string Email { get; }
        public virtual Course FavoriteCourse { get; }

        private readonly List<Enrollment> _enrollments = new List<Enrollment>();
        public virtual IReadOnlyList<Enrollment> Enrollments => _enrollments.ToList();

        protected Student()
        {
        }

        public Student(string name, string email, Course favoriteCourse)
            : this()
        {
            Name = name;
            Email = email;
            FavoriteCourse = favoriteCourse;
        }

        public void EnrollIn(Course course, Grade grade)
        {
            var enrollment = new Enrollment(course, this, grade);
            _enrollments.Add(enrollment);
        }
    }
}
