using System;
using System.Collections.Generic;
using System.Linq;
using VideoStore.Core;

namespace VideoStore.Data
{
    public class TestData : IVideoData
    {
        List<Video> _videoList;

        public IEnumerable<Video> ListVideos(string title)
        {
            return _videoList.Where(x => string.IsNullOrEmpty(title) || x.Title.StartsWith(title)).OrderBy(x => x.Title);
        }

        public TestData()
        {
            _videoList = new List<Video>()
            {
                new Video {Id = 1, Title = "Movie Title 1", TimeReleased = new DateTime(2018, 1, 2), Genre = VideoGenre.Comedy },
                new Video {Id =2 , Title = "Escape From Sorbibor", TimeReleased = new DateTime(1995, 11, 10), Genre = VideoGenre.Thriller},
                new Video {Id =2 , Title = "The Matrix", TimeReleased = new DateTime(2010, 8, 30), Genre = VideoGenre.Action},

            };
        }

        public IEnumerable<Video> ListOfVideos() => _videoList.OrderBy(x => x.Title);
    }
}
