using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManeger : MonoBehaviour
{
    public static bool isLevelFail;
    public GameObject LevelFailScreen;
    public GameObject LevelSucsessScreen;
    public static bool isLevelSucsess;
    public GameObject fruit1;
    public GameObject fruit2;
    public static bool fruit1ApearanceTime;
    public static bool fruit2ApearanceTime;
    private void Awake()
    {
        isLevelFail = false;
        isLevelSucsess = false;
        fruit2ApearanceTime= false;
        fruit1ApearanceTime=false;
       
    }

    // Update is called once per frame
    void Update()
    {
        
        if (isLevelFail)
        {
            LevelFailScreen.SetActive(true);
        }
        if(isLevelSucsess)
        {
            LevelSucsessScreen.SetActive(true);
        }
        if (fruit1ApearanceTime)
        {
            fruit1.SetActive(true);
        }
        if(fruit2ApearanceTime)
        {
          fruit2.SetActive(true);
        }
    }
}
