using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class objectsFallLine : MonoBehaviour
{
    public GameManeger gm;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.CompareTag("Player"))
        {

            gm.totalNumberOfFruitsLeft--;
            GameManeger.failCounter++;
            Debug.Log("Fail:" + GameManeger.failCounter + "totalNumerLeft: " + gm.totalNumberOfFruitsLeft);

        }
        if (GameManeger.failCounter > gm.minforLevelSucsess || ((gm.totalNumberOfFruitsLeft == 0) && (!GameManeger.isLevelSucsess)))
        {
            GameManeger.isLevelFail = true;
            HealthSystem.health--;
        }
        else if (GameManeger.SucsessCounter >= gm.minforLevelSucsess && gm.totalNumberOfFruitsLeft == 0)
            GameManeger.isLevelSucsess = true;
    }
}
