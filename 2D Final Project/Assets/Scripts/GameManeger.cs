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
    public GameObject stageReqMenu;


    private void Awake()
    {
        isLevelFail = false;
        isLevelSucsess = false;
        SucsessCounter = 0;
        failCounter = 0;
        stageReqMenu.SetActive(true);
        Time.timeScale = 0;

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
        
    }
}
