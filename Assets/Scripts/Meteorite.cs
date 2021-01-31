using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteorite : MonoBehaviour
{
    public float speed = 10;
    public float scaleSpeed;
    private float scale = 1;
    private void Update()
    {
        scale -= Time.deltaTime * scaleSpeed;
        scale = Mathf.Clamp(scale, 0.25f, 1);
        transform.RotateAround(new Vector3(100, 0, 0), new Vector3(0, 0, -1), speed * Time.deltaTime);
        transform.localScale = new Vector3(scale, scale, scale);

        if (transform.position.x > 103)
        {
            transform.position = new Vector3(74.5f, -4.8f);
            transform.localScale = new Vector3(1, 1, 1);
        }

    }
}
