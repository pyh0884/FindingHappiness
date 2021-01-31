using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteorite : MonoBehaviour
{
    public float speed = 10;
    public float scaleSpeed;
    private float scale = 1;
    public Vector3 startPoint = new Vector3(74.5f, -4.8f);
    private void Start()
    {
        scale = transform.localScale.x;
    }
    private void Update()
    {
        scale -= Time.deltaTime * scaleSpeed;
        scale = Mathf.Clamp(scale, 0.25f, 1);
        transform.RotateAround(new Vector3(100, 0, 0), new Vector3(0, 0, -1), speed * Time.deltaTime);
        transform.localScale = new Vector3(scale, scale, scale);

        if (transform.position.x > 101)
        {
            transform.position = startPoint;
            scale = 1;
        }

    }
}
