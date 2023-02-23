using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class failScreenLives : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject OneLives;
    public GameObject TwoLives;
    public GameObject ThreeLives;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(HealthSystem.health == 3)
        {
            ThreeLives.SetActive(true);
            TwoLives.SetActive(false);
            OneLives.SetActive(false);
        }
        else if(HealthSystem.health == 2)
        {
            ThreeLives.SetActive(false);
            TwoLives.SetActive(true);
            OneLives.SetActive(false);
        }
        else if(HealthSystem.health == 1)
        {
            ThreeLives.SetActive(false);
            TwoLives.SetActive(false);
            OneLives.SetActive(true);
        }
        
    }
}
