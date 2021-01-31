using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBall : MonoBehaviour
{
    public Sprite[] sprites;
    public float PressTime = 2;
    private float timer = 0;
    private bool isPressed = false;
    private int currentState = 0;
    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isPressed = true;
        }
    }

    private void OnMouseUp()
    {
        if (Input.GetMouseButtonUp(0))
        {
            isPressed = false;
        }
    }
    private void OnMouseExit()
    {
        isPressed = false;
    }
    private void Update()
    {
        if (isPressed)
        {
            timer += Time.deltaTime;
        }
        else
        {
            timer -= Time.deltaTime;
            timer = Mathf.Clamp(timer, 0, PressTime);
        }
        if (timer > PressTime)
        {
            currentState += 1;
            GetComponent<SpriteRenderer>().sprite = sprites[currentState];
            isPressed = false;
            timer = 0;
        }
        transform.eulerAngles = new Vector3(0, 0, 180 * timer / PressTime);
        if (currentState == 4)
        {
            Destroy(this);
        }
    }
}
