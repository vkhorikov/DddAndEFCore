using System.Linq;

namespace App
{
    public class Suffix : Entity
    {
        public static readonly Suffix Jr = new Suffix(1, "Jr");
        public static readonly Suffix Sr = new Suffix(2, "Sr");

        public static readonly Suffix[] AllSuffixes = { Jr, Sr };

        public string Name { get; }

        protected Suffix()
        {
        }

        private Suffix(long id, string name)
            : base(id)
        {
            Name = name;
        }

        public static Suffix FromId(long id)
        {
            return AllSuffixes.SingleOrDefault(x => x.Id == id);
        }
    }
}
