﻿namespace Events;

public class VideoEncoder
{
    // STEPS
    // 1 - Define a delegate
    // 2 - Define an event based on that delegate
    // 3 - Raise the event

    // EventHandler
    // EventHandler<TEventArgs>
    
    public event EventHandler<VideoEventArgs> VideoEncoded;
    
    public void Encode(Video video)
    {
        
        Console.WriteLine("Encoding video...");
        Thread.Sleep(3000);
        
        OnVideoEncoded(video);
    }

    protected virtual void OnVideoEncoded(Video video)
    {
        if(VideoEncoded != null)
            VideoEncoded(this, new VideoEventArgs() { Video = video });
    }
}