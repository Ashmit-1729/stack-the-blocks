using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePlankFall : MonoBehaviour
{
    public Rigidbody2D plankRigidbody;
    public float currentTime = 0f;
    public float timeBetweenTaps = 1f; // Set your desired time between taps here
    public float moveSpeed = 2.0f; // Adjust the speed as needed
    public bool moveRight = true;
   
    public MoveHook hook; // Reference to the hook GameObject
    public float yheight = 2.0f; // Adjust the value as needed
    //bool hookMoveRight = hook.GetComponent<MoveHook>().moveRight; // Assuming MoveHook controls hookmovement
    

    // Start is called before the first frame update
    void Start()
    {
        plankRigidbody = GetComponent<Rigidbody2D>();
        plankRigidbody.gravityScale = 0; // Set gravity scale to 0 initially
    }

    // Update is called once per frame
    void Update()
    {
        
        currentTime += Time.deltaTime;
        if (transform.position.y > yheight)
        {
    // if (hookMoveRight)
    // {
    //     transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
    // }
    // else
    // {
    //     transform.Translate(-Vector2.right * moveSpeed * Time.deltaTime);
    // }

    // if (transform.position.x >= 0.5f)
    // {
    //     hookMoveRight = false;
    // }

    // if (transform.position.x <= -0.5f)
    // {
    //     hookMoveRight = true;
    // }

    if (hook.moveRight)
        {
            transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
        }
        else
        {
            transform.Translate(-Vector2.right * moveSpeed * Time.deltaTime);
        }
            if (transform.position.x >= 1.6f)
            {
                hook.moveRight = false;
            }

            if (transform.position.x <= -1.6f)
            {
                hook.moveRight = true;
            }
    }


        if (Input.GetMouseButtonDown(0) && currentTime >= timeBetweenTaps)
        {
            plankRigidbody.gravityScale = 1;
            currentTime = 0f; // Reset the timer
        }
    }
}
