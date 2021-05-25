using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTest3Smart : EnemyTest2Movement
{
    [SerializeField] float followDistance;


    public override void Update()
    {
        if (!dead)
        {
            base.Update();
            if (distanceToPlayer <= followDistance)
            {
                Vector3 target = new Vector3(player.transform.position.x, transform.position.y, player.transform.position.z);
                transform.LookAt(target);
            }
            Move();
        }
    }

    public override void Rotate()
    {
        if (distanceToPlayer <= followDistance) return;
        
        base.Rotate();
    }
}
