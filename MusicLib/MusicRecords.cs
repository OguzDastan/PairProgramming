using System;

namespace MusicLib
{
    public class MusicRecords
    {
        private string _title;
        private string _artist;
        private double _duration;
        private DateTime _publishDate;
        private string _genre;

        public MusicRecords(string title, string artist, double duration, DateTime publishdate, string genre)
        {
            title = Title;
            artist = Artist;
            duration = Duration;
            publishdate = PublishDate;
            genre = Genre;
        }


        public string Title
        {
            get => _title;
            set => _title = value;
        }

        public string Artist
        {
            get => _artist;
            set => _artist = value;
        }

        public double Duration
        {
            get => _duration;
            set => _duration = value;
        }

        public DateTime PublishDate
        {
            get => _publishDate;
            set => _publishDate = value;
        }

        public string Genre
        {
            get => _genre;
            set => _genre = value;
        }
    }
}
