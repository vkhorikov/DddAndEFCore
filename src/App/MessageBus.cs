namespace App
{
    public sealed class MessageBus
    {
        private readonly IBus _bus;

        public MessageBus(IBus bus)
        {
            _bus = bus;
        }

        public void SendEmailChangedMessage(long studentId, string newEmail)
        {
            _bus.Send("Type: STUDENT_EMAIL_CHANGED; " +
                $"Id: {studentId}; " +
                $"NewEmail: {newEmail}");
        }
    }
}