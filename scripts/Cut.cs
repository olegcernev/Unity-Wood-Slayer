using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cut : MonoBehaviour
{
     

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Tahta")
        {
            Destroy(other.gameObject);
             
        }

        else if (other.gameObject.tag == "Metal")
        {
            Debug.Log("OyunBitti!!");
        }
    }
}
