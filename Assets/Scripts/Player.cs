using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool isPlayer1 = true;
    
    [Header("Movement")]
    public float speed = 10;
    
    [Header("Shooting")]
    public Transform bulletSpawn;
    public GameObject bulletPrefab;
    private float cooldown = 2;
    
    void Start()
    {
        InvokeRepeating(nameof(Shoot), cooldown, cooldown);
    }

    void Shoot()
    {
        //TODO: vfx & sound
        var bullet = Instantiate(bulletPrefab, bulletSpawn.position, transform.rotation);
        bullet.GetComponent<Rigidbody>().AddForce(20 * transform.forward, ForceMode.Impulse);
    }
    

    void Update()
    {
        var direction = new Vector3();

        if (isPlayer1)
        {
            direction.x = Input.GetAxisRaw("Horizontal1");
            direction.z = Input.GetAxisRaw("Vertical1");
        }
        else
        {
            direction.x = Input.GetAxisRaw("Horizontal2");
            direction.z = Input.GetAxisRaw("Vertical2");
        }
        
        
        transform.position += direction.normalized * speed * Time.deltaTime;
        
        if(direction != Vector3.zero)
            transform.forward = direction.normalized;
    }
}
