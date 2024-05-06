using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BirdBehaviour : MonoBehaviour
{
    // public float Speed = 1;
    public Rigidbody2D Rigidbody;
    public float JumpForce = 2f;

    void Start()
    {
        Rigidbody.velocity = Vector2.up * JumpForce;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Rigidbody.velocity = Vector2.up * JumpForce;
        }

    }
}
