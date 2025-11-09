using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float lifetime = 3;
    
    void Start()
    {
        Invoke(nameof(SelfDestruct), lifetime);
    }

    void SelfDestruct()
    {
        //TODO: vfx
        Destroy(gameObject);
    }
}
