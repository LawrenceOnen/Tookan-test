using System;
using NetCore.Docker;

namespace NetCore.Docker
{
    class Program
    {
        static void Main(string[] args)
        {
            //The video to encode
            Video video = new Video() { Title = "Ghost of the last heavens",  Rating = 8};
            //Instance of the encoder that will encode the video
            var videoEconder = new VideoEncoder(); //publisher

            var mailService = new MailService();//subscriber
            var messageService = new MessageService(); // Another subscriber
            
            //Register with publisher with a reference/pointer to the OnvideoEncoded method

            videoEconder.VideoEncoded += mailService.OnVideoEncoded;
            videoEconder.VideoEncoded += messageService.OnVideoEncoded;
            videoEconder.Encode(video);
        }
    }

}
