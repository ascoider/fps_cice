using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDamage : MonoBehaviour
{
    internal int damage;
    internal bool canDamage = true;


    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enviroment")
        {
            canDamage = false;
            Destroy(gameObject, 3f);
        }
    }

}
