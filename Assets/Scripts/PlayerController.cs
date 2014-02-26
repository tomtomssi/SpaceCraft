using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    private Movement m;

    public GameObject player;

    public float verticalSpeed;
    public float horizontalSpeed;

    public float maxVerticalSpeed;
    public float maxHorizontalSpeed;

    // Use this for initialization
    void Start()
    {
        m = new Movement(player, verticalSpeed, horizontalSpeed, maxVerticalSpeed, maxHorizontalSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        keyboardInput();
    }

    void keyboardInput()
    {
        if (Input.GetKey(KeyCode.W))
        {
            m.move("UP");
        }

        if (Input.GetKey(KeyCode.S))
        {
            m.move("DOWN");
        }

        if (Input.GetKey(KeyCode.A))
        {
            m.move("LEFT");
        }

        if (Input.GetKey(KeyCode.D))
        {
            m.move("RIGHT");
        }
    }
}
