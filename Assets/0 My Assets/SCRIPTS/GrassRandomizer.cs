using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassRandomizer : MonoBehaviour
{
    [SerializeField] Transform[] grassParts;
    float randomPosX, randomPosZ;


    void Start()
    {
        for (int i = 0; i < grassParts.Length; i++)
        {
            grassParts[i].Rotate(0, Random.Range(0, 360), 0);
            float scaleRandom = Random.Range(2f, 4f);
            grassParts[i].localScale *= scaleRandom;

            randomPosX = Random.Range(-1f, 1f);
            randomPosZ = Random.Range(-1f, 1f);
            Vector3 newRandomPos = new Vector3(randomPosX, 0, randomPosZ);
            grassParts[i].localPosition += newRandomPos;
        }

    }

    
}
