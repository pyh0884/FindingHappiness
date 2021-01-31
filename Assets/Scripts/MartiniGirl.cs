using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MartiniGirl : MonoBehaviour
{
    public bool isMoving;
    public Transform direction;
    [Range(10, 30)]
    public float force;
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            GetComponent<Animator>().SetTrigger("Rotate");
        }
        Debug.DrawLine(transform.position, direction.position, Color.blue);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Coin" && isMoving)
        {
            Vector2 dir = direction.position - transform.position;
            collision.GetComponent<Rigidbody2D>().AddForce(dir.normalized * force, ForceMode2D.Impulse);
        }
    }
}
