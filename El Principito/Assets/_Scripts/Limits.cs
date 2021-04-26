using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Limits : MonoBehaviour
{

    public float moveForce;
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Item"))
        {
            Rigidbody2D rigidbodyItem = collision.gameObject.GetComponent<Rigidbody2D>();

            Vector2 awayFromLimits = collision.gameObject.transform.position - transform.position;
            
            rigidbodyItem.AddForce(awayFromLimits * moveForce, ForceMode2D.Impulse);
        }
    }
}
