using System.Collections.Generic;
using CSharpFunctionalExtensions;

namespace App
{
    public class Name : ValueObject
    {
        public string First { get; }
        public string Last { get; }

        protected Name()
        {
        }

        private Name(string first, string last)
            : this()
        {
            First = first;
            Last = last;
        }

        public static Result<Name> Create(string firstName, string lastName)
        {
            if (string.IsNullOrWhiteSpace(firstName))
                return Result.Failure<Name>("First name should not be empty");
            if (string.IsNullOrWhiteSpace(lastName))
                return Result.Failure<Name>("Last name should not be empty");

            firstName = firstName.Trim();
            lastName = lastName.Trim();

            if (firstName.Length > 200)
                return Result.Failure<Name>("First name is too long");
            if (lastName.Length > 200)
                return Result.Failure<Name>("Last name is too long");

            return Result.Success(new Name(firstName, lastName));
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return First;
            yield return Last;
        }
    }
}
