using UnityEngine;
using System.Collections;

public class Movement
{

    public GameObject player;

    public float verticalSpeed;
    public float horizontalSpeed;

    public float maxVerticalSpeed;
    public float maxHorizontalSpeed;

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
    /// Sets moves the element to the target direction
    /// </summary>
    /// <param name="dir">RIGHT, LEFT, UP, DOWN</param>
    public void move(string dir)
    {
        switch (dir)
        {
            case "RIGHT":
                player.rigidbody2D.AddForce(Vector2.right * verticalSpeed);
                break;
            case "LEFT":
                player.rigidbody2D.AddForce(-Vector2.right * verticalSpeed);
                break;
            case "UP":
                player.rigidbody2D.AddForce(Vector2.up * horizontalSpeed);
                break;
            case "DOWN":
                player.rigidbody2D.AddForce(-Vector2.up * horizontalSpeed);
                break;
            default:
                break;
        }
    }
}
