namespace App
{
    public class Enrollment : Entity
    {
        public Grade Grade { get; }
        public virtual Course Course { get; }
        public virtual Student Student { get; }

        protected Enrollment()
        {
        }

        public Enrollment(Course course, Student student, Grade grade)
            : this()
        {
            Course = course;
            Student = student;
            Grade = grade;
        }
    }
}
