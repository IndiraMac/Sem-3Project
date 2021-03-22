using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public float Offset;
    public GameObject bullets;

    public Transform spawnPoint;

    private float shootTime;
    public float shootStartTime;

    private void Update()
    {
        Vector3 angleDifference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotationZ = Mathf.Atan2(angleDifference.y, angleDifference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotationZ + Offset);

        if(shootTime <= 0)
        {
            if(Input.GetMouseButtonDown(1))
            {
               Instantiate(bullets, spawnPoint.position, transform.rotation);
                shootTime = shootStartTime;
            }
        }
        else
        {
            shootTime -= Time.deltaTime;
        }
        
    }
}
