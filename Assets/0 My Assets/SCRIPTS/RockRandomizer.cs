using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockRandomizer : MonoBehaviour
{


    void Start()
    {
        transform.Rotate(0, Random.Range(0, 360), 0);

        float scaleRandom = Random.Range(1f, 3f);
        transform.localScale *= scaleRandom;
    }
}
