using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncyCoin : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "LightBall")
        {
            collision.GetComponent<LightBall>().enabled = true;
            Destroy(gameObject, 0.15f);
        }
    }
}
