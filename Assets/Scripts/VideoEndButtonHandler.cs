using UnityEngine;
using UnityEngine.UI; // Add this namespace to work with UI components
using UnityEngine.Video;

public class VideoEndButtonHandler : MonoBehaviour
{
    [SerializeField]
    private VideoPlayer myVideoPlayer;

    [SerializeField]
    private Button loadSceneButton; // Reference to the button

    void Start()
    {
        if (myVideoPlayer == null)
        {
            Debug.LogError("VideoPlayer is not assigned.");
            return;
        }

        if (loadSceneButton == null)
        {
            Debug.LogError("Load Scene Button is not assigned.");
            return;
        }

        // Initially hide the button
        loadSceneButton.gameObject.SetActive(false);

        // Register the callback when the video ends
        myVideoPlayer.loopPointReached += OnVideoEnd;
    }

    void OnVideoEnd(VideoPlayer vp)
    {
        // Show the button when the video ends
        loadSceneButton.gameObject.SetActive(true);
    }
}
