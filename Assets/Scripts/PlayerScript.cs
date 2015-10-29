using UnityEngine;
using System.Collections;
using System.Collections.Generic;

//Adapted from Introduction to Game Design, Prototyping, and Development by Jeremy Gibson
public class PlayerScript : MonoBehaviour
{
    Animator defending;
    private float distance;
    public float speed = 0.5f;

    public Transform characterTrans;

    Rigidbody2D Player;

    void Awake()
    {
        characterTrans = transform.Find("CharacterTrans");
    }

    //Get rigidbody and defending animation
    void Start()
    {
        Player = GetComponent<Rigidbody2D>();
        defending = GetComponent<Animator>();
    }

    //Thrust sword when mouse is clicked
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            defending.SetTrigger("Defend");
        }
    }
}