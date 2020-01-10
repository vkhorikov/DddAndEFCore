using System.Linq;

namespace App
{
    public class Course : Entity
    {
        public static readonly Course Calculus = new Course(1, "Calculus");
        public static readonly Course Chemistry = new Course(2, "Chemistry");

        public static readonly Course[] AllCourses = { Calculus, Chemistry };

        public string Name { get; }

        protected Course()
        {
        }

        private Course(long id, string name)
            : base(id)
        {
            Name = name;
        }

        public static Course FromId(long id)
        {
            return AllCourses.SingleOrDefault(x => x.Id == id);
        }
    }
}
