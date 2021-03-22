using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AltEnemies : MonoBehaviour
{
    public int enemyHealth;

    private void Update()
    {
        if (enemyHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void TakeBulletDamage(int bulletDamage)
    {
        enemyHealth -= bulletDamage;
    }
}
