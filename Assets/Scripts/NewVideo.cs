using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class NewVideo : MonoBehaviour
{
    public Button button;
    public Sprite StartSprite;
    public Sprite StopSprite;
    public VideoClip videoClip; // Reference to the video clip

    private VideoPlayer player;

    void Start()
    {
        player = GetComponent<VideoPlayer>();
        button.onClick.AddListener(ChangeStartStop); // Listen to button click event
    }

    void ChangeStartStop()
    {
        if (player.isPlaying == false)
        {
            if (videoClip != null)
            {
                player.clip = videoClip; // Assign the video clip to the player
                player.Play();
                button.image.sprite = StopSprite;
            }
            else
            {
                Debug.LogWarning("No video clip assigned!");
            }
        }
        else
        {
            player.Pause();
            button.image.sprite = StartSprite;
        }
    }
}
