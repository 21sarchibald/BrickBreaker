using UnityEngine;

public class BallController : MonoBehaviour
{
    private Rigidbody2D ball;

    public float ballSpeed = 8f;
    public Vector2 launchDirection = new Vector2(1f, 1f);
    void Start()
    {
        ball = GetComponent<Rigidbody2D>();
        
        // float horizontal = Mathf.Sign(transform.position.x);
        //
        // if (horizontal == 0)
        // {
        //     horizontal = 1;
        // }
        ball.linearVelocity = launchDirection.normalized * ballSpeed;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        ball.linearVelocity = ball.linearVelocity.normalized * ballSpeed;
        FixStuckAngles();
    }

    void FixStuckAngles()
    {
        Vector2 v = ball.linearVelocity;
        if (Mathf.Abs(v.y) < 0.5f)
        {
            v.y = 0.5f * Mathf.Sign(v.y == 0 ? 1 : v.y);
        }
        if (Mathf.Abs(v.x) < 0.5f)
        {
            v.y = 0.5f * Mathf.Sign(v.y == 0 ? 1 : v.x);
        }
        
        ball.linearVelocity = v.normalized * ballSpeed;
    }
}
