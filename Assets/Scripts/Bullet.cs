using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float lifetime = 3;
    public int damage = 10;

    [Header("VFX")] 
    public GameObject explosion;
    
    void Start()
    {
        Invoke(nameof(SelfDestruct), lifetime);
    }

    void SelfDestruct()
    {
        Instantiate(explosion, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.transform.CompareTag("Player"))
        {
            var health = other.gameObject.GetComponent<Health>();
            if (health != null)
            {
                health.Damage(damage);
                SelfDestruct();
            }
        }
    }
}
