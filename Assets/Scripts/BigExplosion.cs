using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigExplosion : MonoBehaviour
{
    public float radus = 6;
    public float force = 60;
    public ForceMode mode = ForceMode.Impulse;
    
    void Start()
    {
        var collider = Physics.OverlapSphere(transform.position, radus);

        foreach (var c in collider)
        {
            var rb = c.attachedRigidbody;
            if (rb != null)
            {
                var direction = (rb.transform.position - transform.position).normalized;
                rb.AddForce(direction * force, mode);
            }
            var heath = c.GetComponent<Health>();
            if (heath != null)
            {
                heath.Damage(20);
            }
        }
    }
    
}
