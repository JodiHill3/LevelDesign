using UnityEngine;
using UnityEngine.Video;

public class LoopNextVideo : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public VideoClip newVideoClip;  // The new video that will loop after the current video ends

    void Start()
    {
        if (videoPlayer == null)
        {
            videoPlayer = GetComponent<VideoPlayer>();
        }

        // Subscribe to the loopPointReached event to detect when the video ends
        videoPlayer.loopPointReached += OnVideoEnd;
    }

    void OnVideoEnd(VideoPlayer vp)
    {
        // Unsubscribe from the event to avoid repeated calls
        videoPlayer.loopPointReached -= OnVideoEnd;

        // Set the new video clip
        videoPlayer.clip = newVideoClip;

        // Enable looping
        videoPlayer.isLooping = true;

        // Play the new video
        videoPlayer.Play();
    }
}
