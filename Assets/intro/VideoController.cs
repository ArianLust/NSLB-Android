using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class VideoController : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public string nextSceneName = "Scene15"; // Change this to your scene name

    void Start()
    {
        // Subscribe to video player events
        videoPlayer.loopPointReached += EndReached;
    }

    void EndReached(VideoPlayer vp)
    {
        // Called when the video player reaches the end
        // Load the next scene
        SceneManager.LoadScene(nextSceneName);
    }

    public void PlayVideo()
    {
        // Start playing the video
        videoPlayer.Play();
    }
}
