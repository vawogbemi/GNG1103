using UnityEngine;
using UnityEngine.Video;
using Adrenak.UniVRMedia;

public class Context : MonoBehaviour {
    [SerializeField]
    VRMediaPlayer.Configuration options;

    public void Start () {
        VRMediaPlayer player = new VRMediaPlayer(options);

        player.Video.source = VideoSource.Url;
        player.Video.url = "C:/Users/Victor A/Documents/Projects/GNG1103/Assets/Adrenak/UniVRMedia/Demo/TravelTheWorldInVR.mp4";
        //player.Video.VideoClip = "TravelTheWorldInVR.mp4";
        player.Video.isLooping = false;
        player.Video.loopPointReached += delegate (VideoPlayer source) {
            if (!player.Video.isLooping)
                player.Video.Stop();
        };

        player.Play();
    }
}
