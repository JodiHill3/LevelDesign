using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.Sprites;
using UnityEngine.UI;

public class StartStop : MonoBehaviour
{
   private VideoPlayer player;
    public Button button;
    public Sprite StartSprite;
    public Sprite StopSprite;

    void Start()
    {
        player = GetComponent<VideoPlayer>();
    }
     
    void Update()
    {
       
    }

    public void ChangeStartStop()
    {
        if (player.isPlaying == true)
        {
            player.Pause();
            button.image.sprite = StartSprite;
        }
        else
        {
            player.Play();
            button.image.sprite = StopSprite;
        }
    }
}
