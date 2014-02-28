using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    private Movement m;

    public GameObject player;
    private SpriteRenderer thrusters;

    public float verticalSpeed;
    public float horizontalSpeed;

    public float maxVerticalSpeed;
    public float maxHorizontalSpeed;

    // Use this for initialization
    void Start()
    {
        m = new Movement(player, verticalSpeed, horizontalSpeed, maxVerticalSpeed, maxHorizontalSpeed);
        thrusters = GameObject.Find("thrusterFlames").GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        thrusters.enabled = keyboardInput() ? true : false;
    }


    private bool keyboardInput()
    {
        bool keyPressed = false;

        if (Input.GetKey(KeyCode.W))
        {
            m.move("UP");
            keyPressed = true;
        }

        if (Input.GetKey(KeyCode.S))
        {
            m.move("DOWN");
            keyPressed = true;
        }

        if (Input.GetKey(KeyCode.A))
        {
            m.move("LEFT");
            keyPressed = true;
        }

        if (Input.GetKey(KeyCode.D))
        {
            m.move("RIGHT");
            keyPressed = true;
        }
        return keyPressed;
    }
}
