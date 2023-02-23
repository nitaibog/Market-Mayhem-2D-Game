using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEngine;

public class GameManeger : MonoBehaviour
{

    public int minforLevelSucsess = 2;//min number of fruits to go to next level
    public int totalNumberOfFruitsLeft = 2;// num of fruits counter initailize
    
    public static int SucsessCounter = 0;
    public static int failCounter = 0;    
    public static bool isLevelFail;
    public GameObject LevelFailScreen;
    public GameObject LevelSucsessScreen;
    public GameObject GameOverScreen;
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
        SucsessCounter = 0;
        failCounter = 0;


    }

    // Update is called once per frame
    void Update()
    {
        
        if (isLevelFail)
        {
            
            
            if (HealthSystem.health == 0 )
            {
                GameOverScreen.SetActive(true);
            }
            else
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
