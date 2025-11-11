using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Barrel : MonoBehaviour
{
    public GameObject effectPrefab;
    public float countdown = 3;
    

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player") || other.gameObject.CompareTag("Bullet") )
        {
            Invoke(nameof(Explode), countdown);

        }
    }

    public void Explode()
    {
        var position = transform.position;
        position.y = 0;
        var rotation = Quaternion.Euler(0, Random.Range(0, 360), 0);
        Instantiate(effectPrefab, position, rotation);
        
        Destroy(gameObject);
    }
}
