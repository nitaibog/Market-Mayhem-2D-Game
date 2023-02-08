using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag_trampoline : MonoBehaviour
{
    private bool dragging = false;
    private Vector2 offset;
    private Vector2 originalPos;

    // Update is called once per frame
    void Awake(){
        originalPos = transform.position;

    }
        // Update is called once per frame
    void Update()
    {
        if(!dragging) return;
        transform.position = new Vector2(Mathf.Clamp(((Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition) + offset).x,(originalPos.x-10f),(originalPos.x+10f)), originalPos.y);

    }
    private void OnMouseDown(){//start dragging
        offset = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
        dragging = true;

    }

    private void OnMouseUp(){//stop dragging
        dragging = false;
    }

}
