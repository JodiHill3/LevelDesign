using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Music : MonoBehaviour
{
    static Music Instance;

  //  bool muted = false;

    AudioSource audioSource;

    [SerializeField] Image img;
    [SerializeField] Sprite spriteMuted;
    [SerializeField] Sprite sprite;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
        audioSource = this.GetComponent<AudioSource>();
    }

    private void Update()
    {
    //    if (Input.GetKeyDown(KeyCode.M))
     //   {
     //       muted = !muted;
        }

    //    if (muted )
    //    {
     //       audioSource.enabled = false;
     //       img.sprite = spriteMuted;
        }
    //    else
     //   {
     //       audioSource.enabled = true;
     //       img.sprite = sprite;
     //   }
  //  }
//}
