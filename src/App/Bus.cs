using System;

namespace App
{
    public sealed class Bus : IBus
    {
        public void Send(string message)
        {
            // Put the message on a bus instead
            Console.WriteLine($"Message sent: '{message}'");
        }
    }
}