using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyTest2Movement : EnemyTest1Base
{
    [SerializeField] internal float movementSpeed = 10f;

    [Range(0, 360)]
    [SerializeField] internal float minAngle, maxAngle;
    [SerializeField] internal float rotationDelay = 1f;


    void Start()
    {
        InvokeRepeating("Rotate", rotationDelay, rotationDelay);
    }


    internal void Move()
    {
        if (!dead)
            transform.Translate(Vector3.forward * Time.deltaTime * movementSpeed);

    }

    public virtual void Rotate()
    {
        int[] signModifier = { -1, 1 };
        int chance = Random.Range(0, 2);
        transform.Rotate(0f, (Random.Range(minAngle, maxAngle) * signModifier[chance]), 0f);
    }

    public override void Attack()
    {
        //TODO - Programar el ataque
    }
}
