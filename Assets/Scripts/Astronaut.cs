using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Astronaut : MonoBehaviour
{
    public GameObject jetpackEFX;
    public float acceleration = 5;
    private Rigidbody2D rb;
    private Vector2 direction;
    public GameObject flag;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Deadzone")
        {
            transform.position = new Vector3(66.87f, 34.54f);
            rb.velocity = Vector2.zero;
        }
        if (collision.gameObject.tag == "Cross")
        {
            flag.SetActive(true);
            FindObjectOfType<GameManager>().currentStage = 5;
        }
    }
    private void Update()
    {
        jetpackEFX.SetActive(false);
        if (Input.GetMouseButton(0))
        {
            jetpackEFX.SetActive(true);
            direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            rb.velocity -= direction.normalized * acceleration;
        }
    }
}
