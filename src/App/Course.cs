namespace App
{
    public class Course : Entity
    {
        public static Course Calculus = new Course(1, "Calculus");
        public static Course Chemistry = new Course(2, "Chemistry");

        public string Name { get; }

        protected Course()
        {
        }

        private Course(long id, string name)
            : base(id)
        {
            Name = name;
        }
    }
}
