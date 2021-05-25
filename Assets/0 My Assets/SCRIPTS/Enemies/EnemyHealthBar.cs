using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealthBar : MonoBehaviour
{
    EnemyTest1Base enemyBase;
    [SerializeField] Image greenBar;

    float maxHealth, currentHealth;
    float delayDisableBar = 1f;


    void Awake()
    {
        enemyBase = transform.parent.gameObject.GetComponent<EnemyTest1Base>();
        maxHealth = enemyBase.healthEnemy;
        currentHealth = maxHealth;
    }

    
    void Update()
    {
        currentHealth = enemyBase.healthEnemy;

        float healthPercentage = currentHealth / maxHealth;
        greenBar.fillAmount = healthPercentage;

        if (healthPercentage <= 0)
        {
            delayDisableBar -= Time.deltaTime;
            if (delayDisableBar <= 0f)
                gameObject.SetActive(false);
        }
            
    }
}
