using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;


public class Vidplayer : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] string videoname;
    private VideoPlayer videoplayer; 
    

    // Update is called once per frame
    
    
    private void Awake()
    {
        videoplayer = GetComponent<VideoPlayer>();
        if (videoplayer)
        {
            videoplayer.url = videoname;
            videoplayer.playOnAwake = false;

            videoplayer.Prepare();
            videoplayer.prepareCompleted += OnVideoPrepared;
        }
    }
    private void OnVideoPrepared(VideoPlayer source)
    {
        videoplayer.Play();
    }
}
