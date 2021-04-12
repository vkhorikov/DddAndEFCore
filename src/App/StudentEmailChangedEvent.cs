namespace App
{
    public sealed class StudentEmailChangedEvent : IDomainEvent
    {
        public long StudentId { get; }
        public Email NewEmail { get; }

        public StudentEmailChangedEvent(long studentId, Email newEmail)
        {
            StudentId = studentId;
            NewEmail = newEmail;
        }
    }
}