using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHook : MonoBehaviour
{
    public  bool moveRight = true;
    public float moveSpeed = 2.0f; // Adjust the speed as needed

    // Start is called before the first frame update
    void Start()
    {
          
    }

    // Update is called once per frame
    void Update()
    {
        if (moveRight)
        {
            transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
        }
        else
        {
            transform.Translate(-Vector2.right * moveSpeed * Time.deltaTime);
        }
            if (transform.position.x >= 1.6f)
            {
                moveRight = false;
            }

            if (transform.position.x <= -1.6f)
            {
                moveRight = true;
            }
    }
}

