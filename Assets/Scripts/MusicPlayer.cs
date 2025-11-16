using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        var players = FindObjectsOfType<MusicPlayer>(true);
        
        // Make sure there isn't more than one music player.
        if (players.Length > 1)
        {
            Destroy(gameObject);
            return;
        }
        
        // Make it so the music keeps playing through restarts
        // (so that it doesn't restart the song every reload)
        DontDestroyOnLoad(gameObject);
    }

}
