using UnityEngine;
using System.Collections;

public class Movement
{

    public GameObject player;

    //Speed of the object
    private float verticalSpeed;
    private float horizontalSpeed;

    //Maximum speed the object is allowed to move
    private float maxVerticalSpeed;
    private float maxHorizontalSpeed;

    /// <summary>
    /// Sets the basic variables for movement
    /// </summary>
    /// <param name="target">Target to be moved</param>
    /// <param name="vs">Target's vertical speed</param>
    /// <param name="hs">Target's horizontal speed</param>
    /// <param name="maxVs">Maximum vertical speed</param>
    /// <param name="maxHs">Maximum horizontal speed</param>
    public Movement(GameObject target, float vs, float hs, float maxVs, float maxHs)
    {
        this.player = target;
        this.verticalSpeed = vs;
        this.horizontalSpeed = hs;
        this.maxHorizontalSpeed = maxHs;
        this.maxVerticalSpeed = maxVs;
    }

    /// <summary>
    /// Moves the element to the target direction using input forces
    /// </summary>
    /// <param name="dir">RIGHT, LEFT, UP, DOWN</param>
    public void move(string dir)
    {
        switch (dir)
        {
            case "RIGHT":
                player.rigidbody2D.AddForce(Vector2.right * verticalSpeed);
                restrictMaxVerticalSpeed();
                break;
            case "LEFT":
                player.rigidbody2D.AddForce(-Vector2.right * verticalSpeed);
                restrictMaxVerticalSpeed();
                break;
            case "UP":
                player.rigidbody2D.AddForce(Vector2.up * horizontalSpeed);
                restrictMaxHorizontalSpeed();
                break;
            case "DOWN":
                player.rigidbody2D.AddForce(-Vector2.up * horizontalSpeed);
                restrictMaxHorizontalSpeed();
                break;
            default:
                break;
        }
    }

    /// <summary>
    /// Sets the element's velocity to zero
    /// </summary>
    public void stop()
    {
        player.rigidbody2D.velocity = Vector2.zero;
    }

    //Restricts the element from exceeding the maximum given vertical speed
    private void restrictMaxVerticalSpeed()
    {
        if (Mathf.Abs(player.rigidbody2D.velocity.x) > maxHorizontalSpeed)
        {
            player.rigidbody2D.velocity = new Vector2(
                Mathf.Sign(player.rigidbody2D.velocity.x) * maxHorizontalSpeed,
                player.rigidbody2D.velocity.y
                );
        }
    }

    //Restricts the element from exceeding the maximum given horizontal speed
    private void restrictMaxHorizontalSpeed()
    {
        if (Mathf.Abs(player.rigidbody2D.velocity.y) > maxVerticalSpeed)
        {
            player.rigidbody2D.velocity = new Vector2(
                player.rigidbody2D.velocity.x,
                Mathf.Sign(player.rigidbody2D.velocity.y) * maxVerticalSpeed
                );
        }
    }
}
