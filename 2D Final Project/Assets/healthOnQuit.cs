using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthOnQuit : MonoBehaviour
{
    // Start is called before the first frame update
    public void healtOnQuit()
    {
        HealthSystem.health = 3;
    }
}
