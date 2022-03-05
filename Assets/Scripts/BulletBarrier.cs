using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBarrier : MonoBehaviour
{
  

    void Start()
    {
       
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullet")
        {
            
            Destroy(other.gameObject);
            

        }

        if (other.tag == "ElcBullet")
        {
            Destroy(other.gameObject);
        }
    }
}
