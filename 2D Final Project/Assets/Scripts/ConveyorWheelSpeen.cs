using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyorWheelSpeen : MonoBehaviour
{
    float rotSpeed = -3;
    private void Update()
    {
        transform.Rotate(0, 0, rotSpeed);
    }
}
