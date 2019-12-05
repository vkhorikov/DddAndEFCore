namespace App
{
    public class Student
    {
        public long Id { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public Course FavoriteCourse { get; private set; }

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
    }
}
