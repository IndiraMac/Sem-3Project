using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlternativeBullet : MonoBehaviour
{
    public float bulletSpeed;
    public float bulletSpawnTime;
    public int bulletDamage;
    
    private void Start()
    {
      
        Invoke("DestroyBullets", bulletSpawnTime);
    }

    
    private void Update()
    {
        transform.Translate(Vector2.right * bulletSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag ("Enemy"))
        {
            Destroy(gameObject);
            collision.GetComponent<AltEnemies>().TakeBulletDamage(bulletDamage);
        }
    }
}
