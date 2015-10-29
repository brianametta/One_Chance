using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GemScript6 : MonoBehaviour
{
    //Load next level when player touches gem
    public void OnCollisionEnter2D(Collision2D TriggerObject)
    {   
        //If player touches gem, load next level
        if (TriggerObject.gameObject.tag == "Player")
        {
            Application.LoadLevel(9);
        }
    }
}

