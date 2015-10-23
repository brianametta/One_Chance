using UnityEngine;
using System.Collections;
using System.Collections.Generic;

//Adapted from Introduction to Game Design, Prototyping, and Development by Jeremy Gibson
public class EnemyScript : MonoBehaviour
{
    Animator fighting;
    private float distance;
    public float speed = 0.5f;
    public float health = 10;
    public GameObject Player;

    private float _maxHealth;
    public Vector3 walkTarget;
    public bool walking;
    public Transform characterTrans;

    Rigidbody2D Briana;

    void Awake()
    {
        characterTrans = transform.Find("CharacterTrans");
        _maxHealth = health; //Puts a top cap on healing
    }

    void Start()
    {
        Briana = GetComponent<Rigidbody2D>();
        fighting = GetComponent<Animator>();
    }

    void Update()
    {
        WalkTo(Player.transform.position);
    }
    //Walk to a position
    public void WalkTo(Vector3 xTarget)
    {
        walkTarget = xTarget;
        walkTarget.z = 0;
        walking = true;
       
    }
    void FixedUpdate()
    {
        Briana.velocity = (walkTarget - Briana.transform.position) * speed;

        fighting.SetFloat("Distance", distance);

        distance = Briana.transform.position.x - walkTarget.x;

        if (distance <= 0.01)
        {
            
        }
    }
    void OnTriggerCollider(Collider TriggerObject)
    {

        health -= 1;
    }
    public void Damage(float amt, bool damageOverTime = false)
    {
        //Collision
        //Decrease Health
        //void Die()
    }
}
