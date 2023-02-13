
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fruit1Apearance : MonoBehaviour
{
    public float delay = 4.0f;
    // Start is called before the first frame update
    private void Start()
    {

        gameObject.SetActive(false);
        Invoke("ActivateObject", delay);
    }

    void ActivateObject()
    {
        gameObject.SetActive(true);
    }
}
