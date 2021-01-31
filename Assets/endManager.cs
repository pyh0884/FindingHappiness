using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endManager : MonoBehaviour
{
    private void Start()
    {
        FindObjectOfType<MoveCamera>().Move(new Vector3(60, -26, -10));
    }
}
