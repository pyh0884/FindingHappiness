using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Astronaut : MonoBehaviour
{
    public GameObject jetpackEFX;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Deadzone")
        {
            transform.position = new Vector3(27.47f, 23.29f);
        }
        if (collision.gameObject.tag == "Cross")
        {
            //TODO:插旗
        }
    }
    private void Update()
    {
        jetpackEFX.SetActive(Input.GetMouseButton(0));
    }
}
