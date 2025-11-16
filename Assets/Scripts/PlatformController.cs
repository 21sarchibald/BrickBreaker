using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlatformController: MonoBehaviour
{
    private Rigidbody2D platform;

    void Start()
    {
        platform = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Move left with left arrow
        if (Keyboard.current.leftArrowKey.isPressed)
        {
            platform.linearVelocity = new Vector2(-10, 0);
            
            
        // Move right with right arrow    
        } else if (Keyboard.current.rightArrowKey.isPressed)
        {
            platform.linearVelocity = new Vector2(10, 0);
        }
        
        // Stay still if no buttons are pressed.
        else
        {
            platform.linearVelocity = new Vector2(0, 0);
        }
        
        // Stop the platform from going outside the walls.
        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, -17f, 17f);
        transform.position = pos;
    }
}