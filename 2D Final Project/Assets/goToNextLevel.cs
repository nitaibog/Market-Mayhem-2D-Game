using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goToNextLevel : MonoBehaviour
{
    public void NextSceneButton(string level)
    {
        SceneManager.LoadScene(level);
    }

}
