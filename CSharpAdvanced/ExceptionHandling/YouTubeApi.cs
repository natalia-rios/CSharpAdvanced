namespace ExceptionHandling;

public class YouTubeApi
{
    public List<Video> GetVideos(string user)
    {
        try
        {
            // Access YouTube web service
            // Read the data
            // Create a list of Video objects

            throw new Exception("Ops some low level Youtube error.");
        }
        catch (Exception exc)
        {
            throw new YouTubeException("Could not fetch the videos from Youtube.", exc);
        }

        return new List<Video>();
    }
}