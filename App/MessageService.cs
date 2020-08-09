using System;

namespace NetCore.Docker
{
     public class MessageService
    {
        public void OnVideoEncoded(object source, EventArgs e)
        {
            Console.WriteLine("Sending message...");
        }
    }
}