using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyTest1Base : MonoBehaviour
{
    [SerializeField] internal int healthEnemy;

    internal bool dead;
    //[SerializeField] internal int damageDealt;
    //[SerializeField] internal float damageReceiveMultiplier;

    [Header("Damage")]
    [SerializeField] GameObject hitPref;
    [SerializeField] GameObject deathPref;
    [SerializeField] AudioClip hitClip, deadClip;

    internal GameObject player;
    internal float distanceToPlayer;

    Rigidbody rb;


    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        if (player == null)
            Debug.LogError("player not found");

        rb = GetComponent<Rigidbody>();
    }


    public virtual void Update()
    {
        DistanceToPlayer();

        void DistanceToPlayer()
        {
            distanceToPlayer = Vector3.Distance(transform.position, player.transform.position);
        }
    }



    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            if (collision.gameObject.GetComponent<BulletDamage>().canDamage)
            {
                UpdateHealth(collision.gameObject.GetComponent<BulletDamage>().damage);
                Vector3 impactPoint = collision.contacts[0].normal;
                rb.AddForce(-impactPoint * 10f);
                Destroy(collision.gameObject);
            }
        }
    }


    public virtual void UpdateHealth(int damage)
    {
        healthEnemy -= damage;
        if (healthEnemy > 0f)
        {
            GameObject impact = Instantiate(hitPref, transform.position, Quaternion.identity);
            impact.transform.SetParent(transform);
            GetComponent<AudioSource>().clip = hitClip;
            GetComponent<AudioSource>().Play();
        }
        else if (!dead)
        {
            Death();
        }
    }

    

    void Death()
    {
        dead = true;

        GetComponent<AudioSource>().clip = deadClip;
        GetComponent<AudioSource>().Play();

        Instantiate(deathPref, transform.position, Quaternion.identity);
        rb.constraints = RigidbodyConstraints.None;
    }
    

    /// <summary>
    ///  Ataque del enemigo
    /// </summary>
    public abstract void Attack();
}
