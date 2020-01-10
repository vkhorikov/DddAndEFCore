using System.Collections.Generic;

namespace App
{
    public class Student : Entity
    {
        public string Name { get; }
        public string Email { get; }
        public virtual Course FavoriteCourse { get; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }

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
    }
}
