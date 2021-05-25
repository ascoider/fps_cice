using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTest3Fool : EnemyTest2Movement
{
    

    public override void Update()
    {
        if (!dead)
        {
            base.Update();
            Move();
        }
    }

}
