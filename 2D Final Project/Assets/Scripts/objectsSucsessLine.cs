using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectsSucsessLine : MonoBehaviour
{
    public GameManeger gm;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            gm.totalNumberOfFruitsLeft --;
            GameManeger.SucsessCounter++;
            if(GameManeger.SucsessCounter >= gm.minforLevelSucsess && gm.totalNumberOfFruitsLeft == 0)
                GameManeger.isLevelSucsess = true;
        }
    }
}
