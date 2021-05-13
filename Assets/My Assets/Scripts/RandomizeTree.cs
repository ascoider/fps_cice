using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomizeTree : MonoBehaviour
{
    public string stringSeed = "seed string";
    public bool useStringSeed;
    int seed;
    public bool randomizeSeed;

    void Awake()
    {
        if (useStringSeed)
            seed = stringSeed.GetHashCode();

        if (randomizeSeed)
            seed = Random.Range(0, 99999);

        Random.InitState(seed);
    }

    
}
