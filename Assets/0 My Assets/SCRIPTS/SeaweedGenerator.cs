using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeaweedGenerator : MonoBehaviour
{
    [SerializeField] GameObject seaweedPref;
    [SerializeField] int seaweedNum = 100;

    float  xSize, zSize;


    void Start()
    {
        xSize = GetComponent<MeshCollider>().bounds.size.x;
        zSize = GetComponent<MeshCollider>().bounds.size.z;
        print($"{xSize}, {zSize}");

        for (int i = 0; i < seaweedNum; i++)
        {
            float xPos = Random.Range(-xSize / 2, xSize / 2);
            float zPos = Random.Range(-zSize / 2, zSize / 2);
            Vector3 pos = new Vector3(xPos, 0f, zPos);
            //float randomScale = Random.Range(-1f, 1f);
            GameObject newPref = Instantiate(seaweedPref, transform.localPosition + pos, transform.rotation);
            //newPref.transform.localScale += new Vector3(randomScale, randomScale, randomScale) * 4;
            newPref.transform.parent = gameObject.transform;
        }
        
    }

    
    void Update()
    {
        
    }
}
