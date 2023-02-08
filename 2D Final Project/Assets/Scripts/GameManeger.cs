using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManeger : MonoBehaviour
{
    public static bool isLevelFail;
    public GameObject LevelFailScreen;
    private void Awake()
    {
        isLevelFail = false;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (isLevelFail)
        {
            LevelFailScreen.SetActive(true);
        }
    }
}
