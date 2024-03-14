using System.Text.Json;

namespace artHouse.Models
{
    public class Video
    {

        public string Id { get; set; }
        public string Title { get; set; }
        public string Preview { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public string Duration { get; set; }
        public int Views { get; set; }
        public int Likes { get; set; }
        public string Uploader { get; set; }
        public DateTime UploadDate { get; set; }
        public string[] Tags { get; set; }
        public float[] Ratings { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Video>(this);
    }
}
