using System;

namespace NetCore.Docker
{
    public class MailService
    {  public void OnVideoEncoded(object source, EventArgs e)
        {
            Console.WriteLine("Sending email...");   
        }
    
    }
}