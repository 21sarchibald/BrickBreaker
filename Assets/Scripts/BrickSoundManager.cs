using UnityEngine;

public class BrickSoundManager : MonoBehaviour
{
    public static BrickSoundManager Instance;
    private AudioSource audioSource;
    public AudioClip brickBreakSound;

    private void Awake()
    {
        // If another BrickSoundManager exists, delete this one
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        
        Instance = this;
        
        // Make sure this script persists across reloads
        DontDestroyOnLoad(gameObject);
        
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
        
        // Don't play the sound immediately when the scene loads
        audioSource.playOnAwake = false;
    }

    public void PlayBrickBreakSound()
    {
        // If there is a sound, play it
        if (brickBreakSound != null)
        {
            audioSource.PlayOneShot(brickBreakSound);
        }
        
        // Send a warning that there isn't a sound assigned to brickBreakSound
        else
        {
            Debug.LogWarning("Brick break sound is null");
        }
    }

}
