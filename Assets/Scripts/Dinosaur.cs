using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dinosaur : MonoBehaviour
{
    public float jumpForce = 15;
    public float speed = 6;
    public Vector3 startPoint;
    private Rigidbody2D rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.left * speed;
    }
    void Update()
    {
        if (Mathf.Abs(rb.velocity.x) < 0.1f)
        {
            rb.velocity = Vector2.left * speed;
        }
        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Deadzone")
        {
            transform.position = startPoint;
            rb.velocity = Vector2.zero;
        }
        if (collision.gameObject.tag == "TurnAround")
        {
            rb.velocity = new Vector2(-rb.velocity.x, rb.velocity.y);
        }
        if (collision.gameObject.tag == "Goal")
        {
            FindObjectOfType<GameManager>().currentStage = 1;
            FindObjectOfType<GameManager>().isReached = false;
            Destroy(gameObject);
        }
    }
}
