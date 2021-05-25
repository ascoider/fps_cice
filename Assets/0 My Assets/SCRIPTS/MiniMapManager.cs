using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMapManager : MonoBehaviour
{
    [SerializeField] float animationTime = 1f;
    float timeElapsed;
    [SerializeField] Transform player;
    [SerializeField] Transform miniPlayer;

    bool isShowing;
    bool isAnimating;


    void Awake()
    {
        timeElapsed = animationTime;
    }


    void Update()
    {
        if (isAnimating)
        {
            timeElapsed -= Time.deltaTime;
            if (timeElapsed <= 0f)
            {
                timeElapsed = animationTime;
                isAnimating = false;
            }
        }

        GetPlayerPosition();

        if (!isAnimating && Input.GetKeyDown(KeyCode.M))
        {
            if (!isShowing)
                AnimateMap(true);
            else
                AnimateMap(false);
        }

    }

    void GetPlayerPosition()
    {
        miniPlayer.localPosition = new Vector3(player.transform.position.x / 100f, 0f, player.transform.position.z / 100f);
    }

    void AnimateMap(bool state)
    {
        isAnimating = true;
        GetComponent<Animator>().SetBool("isShowing", state);
        isShowing = state;
    }
    
}