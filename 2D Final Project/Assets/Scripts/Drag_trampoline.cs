using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag_trampoline : MonoBehaviour
{
    private bool dragging = false;
    private Vector2 offset;
    private Vector2 originalPos;
    public float TrampolineRange = 10f;
    public bool isYMovement = false;
    public bool isMagnet = false;
    Collider2D objectCollider;
    public Effector2D Magnet;
    public AudioSource audioEffect;
    // Update is called once per frame
    void Awake(){
        originalPos = transform.position;

    }
        // Update is called once per frame
    void Update()
    {
        if(!dragging) return;
        if(!isYMovement)
            transform.position = new Vector2(Mathf.Clamp(((Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition) + offset).x,(originalPos.x-TrampolineRange),(originalPos.x+TrampolineRange)), originalPos.y);
        if(isYMovement)
            transform.position = new Vector2(originalPos.x, Mathf.Clamp(((Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition) + offset).y, (originalPos.y - TrampolineRange), (originalPos.y + TrampolineRange)));

    }
    private void OnMouseDown(){//start dragging
        offset = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
        dragging = true;
        if (isMagnet)
        {
            objectCollider = GetComponent<Collider2D>();
            Magnet = GetComponent < PointEffector2D>();
            objectCollider.isTrigger = true;
            
        }

    }

    private void OnMouseUp(){//stop dragging
        dragging = false;
        objectCollider.isTrigger = false;
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            audioEffect.Play(); ;
        }
    }

}
