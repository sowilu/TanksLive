using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ice : MonoBehaviour
{
    public float lifetime = 15;
    void Start()
    {
        Invoke(nameof(SelfDistruct), lifetime);
    }

    void SelfDistruct()
    {
        //TODO: vfx
        Destroy(gameObject);
    }
}
