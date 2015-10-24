using UnityEngine;
using System.Collections;
using System.Collections.Generic;

//Adapted from Introduction to Game Design, Prototyping, and Development by Jeremy Gibson
public class EnemyScript : MonoBehaviour
{
    Animator fighting;
    Animator die;
    private float distance;
    public float speed = 0.5f;
    public float health = 10;
    public GameObject Player;

    public Vector3 walkTarget;
    public bool walking;
    public Transform characterTrans;

    Rigidbody2D Briana;

    void Awake()
    {
        characterTrans = transform.Find("CharacterTrans");
    }

    void Start()
    {
        Briana = GetComponent<Rigidbody2D>();
        fighting = GetComponent<Animator>();
        die = GetComponent<Animator>();
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

        distance = Briana.transform.position.x - walkTarget.x;

        fighting.SetFloat("WalkingSpeed", Briana.velocity.x);

        fighting.SetFloat("Distance", distance);
    }

    public void OnCollisionEnter2D(Collision2D TriggerObject)
    { 
        if(TriggerObject.gameObject.tag == "Player")
        {
            health -= 1;
            Debug.Log("Getting Hurt");
        }

       if(health <= 0)
        {
            die.SetTrigger("Death");
            Destroy(Briana);
        }
    }
}
