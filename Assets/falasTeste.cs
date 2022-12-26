using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class falasTeste : MonoBehaviour
{
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" && Input.GetKeyDown("z"))
        {
            print("GRRR...");
        }
    }
}
