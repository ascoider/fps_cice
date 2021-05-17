using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VegetationRandomizer : MonoBehaviour
{
    [SerializeField] GameObject[] vegetationParts;
    [SerializeField] Material[] treeMaterials;
    [SerializeField] float scaleMin, scaleMax;


    void Start()
    {
        transform.Rotate(0, Random.Range(0, 360), 0);

        float scaleRandom = Random.Range(scaleMin, scaleMax);
        transform.localScale *= scaleRandom;

        if (vegetationParts.Length != 0)
        {
            for (int i = 0; i < vegetationParts.Length; i++)
            {
                vegetationParts[i].GetComponent<MeshRenderer>().material = treeMaterials[Random.Range(0, 3)];
            }
        }

    }

    
}
