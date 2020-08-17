using System;
using System.Threading;

namespace NetCore.Docker
{
    
    public class VideoEventArgs : EventArgs
    {
        public Video Video {get; set;}
    }
    public class VideoEncoder
    {
        //Define a delegate method/ Contract that all subcribers will implement
        //Define an event based on that delegate
        //Raise the event
        //Source: current class pulishing the event
        //args: additional data to send with the evvent if any
       public delegate void VideoEncodedHandler(object source, EventArgs args);
      
        //Event based on delegate
        //Event is raised when video has been encoded
        public event VideoEncodedHandler VideoEncoded;

        //Method to raise te event and notify all the subcribers
        protected virtual void OnVideoEncodded()
        {
            if(VideoEncoded != null){
                VideoEncoded(this, EventArgs.Empty);
            }

        }

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video...");
            Thread.Sleep(5000);
            //Raise the event after evideo has been encoded
            OnVideoEncodded();
        }
    }
}