using System;
using NetCore.Docker;

namespace NetCore.Docker
{
    public class Video
    {
        public string Title { get; set;}
        public int Rating { get; set; }
        public int AgeLimit { get; set; }

        //Constructor
         public Video(string title, int rating, int agelimit)
        {
            this.Title = title;
            this.Rating = rating;
            this.AgeLimit = agelimit;
        }

        public Video()
        {
        }
    }
}
