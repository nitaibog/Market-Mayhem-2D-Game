using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyorWheelSpeen : MonoBehaviour
{
    public float rotSpeed = -3;
    private void Update()
    {
        transform.Rotate(0, 0, rotSpeed);
    }
}
