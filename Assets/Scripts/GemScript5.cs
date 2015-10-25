using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GemScript5 : MonoBehaviour
{

    public void OnCollisionEnter2D(Collision2D TriggerObject)
    {
        if (TriggerObject.gameObject.tag == "Player")
        {
            Application.LoadLevel(8);
        }
    }
}

