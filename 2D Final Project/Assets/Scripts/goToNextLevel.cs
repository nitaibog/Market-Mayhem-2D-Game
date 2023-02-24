using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goToNextLevel : MonoBehaviour
{
    public GameObject puase;
    public GameObject puaseMenu;
    public GameObject SettingsMenu;
    public GameObject StageReqMenu;
    

    
    public void NextSceneButton(string level)
    {
        SceneManager.LoadScene(level);
    }
    public void PauseButton(bool pause)
    {
        Time.timeScale = 0;
        puase.SetActive(true);

    }
    public void reasumeButton(bool reasume)
    {
        Time.timeScale = 1;
        puase.SetActive(false);
    }
    public void SettingButton()
    {
        puaseMenu.SetActive(false);
        SettingsMenu.SetActive(true);
    }
    public void okButton(bool reasume)
    {
        Time.timeScale = 1;
        StageReqMenu.SetActive(false);
    }

}
