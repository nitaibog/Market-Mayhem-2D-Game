using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class objectsFallLine : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("fail = true");
            GameManeger.isLevelFail = true;
        }
    }
}
