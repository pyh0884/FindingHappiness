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
            GameObject.Find("光晕").SetActive(true);
            Destroy(FindObjectOfType<MartiniGirl>());
            Destroy(gameObject, 0.15f);
        }
        if (collision.gameObject.tag == "Deadzone")
        {
            FindObjectOfType<CoinGenerator>().Generate();
            Destroy(gameObject);
        }
    }
}
