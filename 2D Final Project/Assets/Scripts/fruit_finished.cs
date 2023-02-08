using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fruit_finished : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision){
        collision.gameObject.GetComponent<SpriteRenderer>().enabled = false;
        collision.gameObject.GetComponent<CircleCollider2D>().enabled = false;
    }
}
