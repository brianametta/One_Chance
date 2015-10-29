using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GemScript5 : MonoBehaviour
{
    //Load next level when player touches gem
    public void OnCollisionEnter2D(Collision2D TriggerObject)
    {
        if (TriggerObject.gameObject.tag == "Player")
        {
            Application.LoadLevel(8);
        }
    }
}

