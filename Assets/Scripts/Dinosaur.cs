using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dinosaur : MonoBehaviour
{
    public float jumpForce = 15;
    private void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.right * 15;
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }
    //if dead respawn?
}
