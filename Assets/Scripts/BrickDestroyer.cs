using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class BrickDestroyer : MonoBehaviour
{
    
    public void OnCollisionEnter2D(Collision2D other)
    {
        // Make sure it's the ball hitting the brick
        if (!other.gameObject.CompareTag("Ball")) return;
        
        // Play explosion sound.
        BrickSoundManager.Instance.PlayBrickBreakSound();
        
        // Destroy brick.
        Destroy(gameObject);
        
        FindFirstObjectByType<GameManager>().BrickDestroyed();
    }

}
