﻿namespace MVC_For_Tests.Services
{
    public interface IMessageService
    {
        string GetMessage();
    }

    public class MessageService : IMessageService
    {
        public string GetMessage()
        {
            return "Hello from MessageService";
        }
    }
}
