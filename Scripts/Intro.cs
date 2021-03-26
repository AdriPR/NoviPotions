using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour
{
    public VideoPlayer VideoPlayer; 
    public string SceneName;

    void Start()
    {
        Screen.orientation = ScreenOrientation.LandscapeLeft;
        VideoPlayer.loopPointReached += LoadScene;
    }

    void LoadScene(VideoPlayer vp)
    {
        Screen.orientation = ScreenOrientation.Portrait;
        SceneManager.LoadScene(SceneName);
    }
}