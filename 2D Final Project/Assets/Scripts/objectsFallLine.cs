using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class objectsFallLine : MonoBehaviour
{
    public GameManeger gm;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.CompareTag("Player"))
        {

            gm.totalNumberOfFruitsLeft--;
            GameManeger.failCounter++;
            if (GameManeger.failCounter > gm.minforLevelSucsess || ((gm.totalNumberOfFruitsLeft == 0) && (!GameManeger.isLevelSucsess)))
            {
                GameManeger.isLevelFail = true;
                HealthSystem.health--;
            }
            
        }
    }
}
