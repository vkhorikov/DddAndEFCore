namespace App
{
    public sealed class StudentController
    {
        private readonly SchoolContext _context;

        public StudentController(SchoolContext context)
        {
            _context = context;
        }

        public string CheckStudentFavoriteCourse(long studentId, long courseId)
        {
            Student student = _context.Students.Find(studentId);
            if (student == null)
                return "Student not found";

            Course course = Course.FromId(courseId);
            if (course == null)
                return "Course not found";

            return student.FavoriteCourse == course ? "Yes" : "No";
        }

        public string AddEnrollment(long studentId, long courseId, Grade grade)
        {
            Student student = _context.Students.Find(studentId);
            if (student == null)
                return "Student not found";

            Course course = Course.FromId(courseId);
            if (course == null)
                return "Course not found";

            student.Enrollments.Add(new Enrollment(course, student, grade));

            return "OK";
        }
    }
}
