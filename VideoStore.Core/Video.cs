using System;

namespace VideoStore.Core
{
    public class Video
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime TimeReleased { get; set; }
        public VideoGenre Genre { get; set; }
    }
}
