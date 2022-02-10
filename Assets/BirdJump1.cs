using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdJump1 : MonoBehaviour
{
    Rigidbody2D rb;
    public float jumpPower;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * jumpPower; //(0,3) 2D game, jump 3
        }

    }
}

//Time: 56.11