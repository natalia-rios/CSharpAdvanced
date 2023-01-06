namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        { 
            try
            {
                var api = new YouTubeApi();
                var videos = api.GetVideos("Mosh");
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }

        }
    }
}