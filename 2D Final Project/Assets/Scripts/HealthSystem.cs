using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthSystem : MonoBehaviour
{
    public static int health = 3;
    public GameObject[] hearts; 
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        foreach (var heart in hearts)
        {
            heart.SetActive(false);
        }
        for (int i = 0; i < health; i++)
        {
            hearts[i].SetActive(true);
        }
    }
}
