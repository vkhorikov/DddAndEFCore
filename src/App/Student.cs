using System;
using System.Collections.Generic;
using System.Linq;

namespace App
{
    public class Student : Entity
    {
        public virtual Name Name { get; private set; }
        public Email Email { get; private set; }
        public virtual Course FavoriteCourse { get; private set; }

        private readonly List<Enrollment> _enrollments = new List<Enrollment>();
        public virtual IReadOnlyList<Enrollment> Enrollments => _enrollments.ToList();

        protected Student()
        {
        }

        public Student(
            Name name, Email email, Course favoriteCourse, Grade favoriteCourseGrade)
            : this()
        {
            Name = name;
            Email = email;
            FavoriteCourse = favoriteCourse;

            EnrollIn(favoriteCourse, favoriteCourseGrade);
        }

        public string EnrollIn(Course course, Grade grade)
        {
            if (_enrollments.Any(x => x.Course == course))
                return $"Already enrolled in course '{course.Name}'";
            
            var enrollment = new Enrollment(course, this, grade);
            _enrollments.Add(enrollment);

            return "OK";
        }

        public void Disenroll(Course course)
        {
            Enrollment enrollment = _enrollments.FirstOrDefault(x => x.Course == course);

            if (enrollment == null)
                return;

            _enrollments.Remove(enrollment);
        }

        public void EditPersonalInfo(Name name, Email email, Course favoriteCourse)
        {
            if (name == null)
                throw new ArgumentNullException();
            if (email == null)
                throw new ArgumentNullException();
            if (favoriteCourse == null)
                throw new ArgumentNullException();

            if (Email != email)
            {
                RaiseDomainEvent(new StudentEmailChangedEvent(Id, email));
            }

            Name = name;
            Email = email;
            FavoriteCourse = favoriteCourse;
        }
    }
}
