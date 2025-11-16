using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class LoseGame : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D other)
    {
        // If the ball hits the bottom wall, call the GameOver script from the GameManager
        if (other.gameObject.CompareTag("Ball"))
        {
            FindFirstObjectByType<GameManager>().GameOver();
        }
    }

}
