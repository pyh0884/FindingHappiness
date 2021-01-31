using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinGenerator : MonoBehaviour
{
    public Transform emitPoint;
    public GameObject coinPrefab;
    public float ShootingSpeed;

    public void Generate() 
    {
        var coin = Instantiate(coinPrefab, transform.position, Quaternion.identity, null);
        coin.GetComponent<Rigidbody2D>().velocity = (emitPoint.position - transform.position).normalized * ShootingSpeed;
    }
}
