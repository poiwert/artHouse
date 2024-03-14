using artHouse.Models;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;

namespace artHouse.Services
{
    public class JsonFileVideoService
    {
        public JsonFileVideoService(IWebHostEnvironment webHostEnvironment)
        {
            this.webHostEnvironment = webHostEnvironment;
        }


        public IWebHostEnvironment webHostEnvironment { get; }

        private string JsonFileName
        {
            get { return Path.Combine(webHostEnvironment.WebRootPath, "data", "Videos.json"); }
        }

        public IEnumerable<Video> GetVideos()
        {
            try
            {
                using (var jsonFileReader = File.OpenText(JsonFileName))
                {
                    var jsonString = jsonFileReader.ReadToEnd();
                    var videos = JsonSerializer.Deserialize<Video[]>(jsonString,
                        new JsonSerializerOptions
                        {
                            PropertyNameCaseInsensitive = true
                        });
                    return videos ?? Enumerable.Empty<Video>(); // Return an empty collection if videos is null
                }
            }
            catch (Exception ex)
            {
                // Log or handle the exception appropriately
                Console.WriteLine($"An error occurred while reading or deserializing videos.json: {ex.Message}");
                return Enumerable.Empty<Video>(); // Return an empty collection or null, depending on your error handling strategy
            }
        }

        public void AddRating(string videoId, int rating)
        {

            var videos = GetVideos();

            // LINQ --------------(SQL)
            var query = videos.First(x => x.Id == videoId);

            if(query.Ratings == null)
            {

                query.Ratings = new float[] { rating }; 

            }
            else
            {

                var ratings = query.Ratings.ToList();
                ratings.Add(rating);
                query.Ratings = ratings.ToArray();
            }

            using (var outputStream = File.OpenWrite(JsonFileName))
            {
                JsonSerializer.Serialize<IEnumerable<Video>>(
                    new Utf8JsonWriter(outputStream, new JsonWriterOptions
                    {
                        SkipValidation = true,
                        Indented = true
                    }),
                    videos
                );
            }

        }

    }
}
