using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

public class fruit_animation : MonoBehaviour
{
    //public AudioSource audio1;
    public AudioSource audio2;
    public AudioSource audio3;
    public Rigidbody2D rigidbody2;
    public GameManeger gm;


    private Animator animator;
    private void Awake()
    {
        animator = GetComponent<Animator>();
        //rigidbody2= GetComponent<Rigidbody2D>();
        
        
    }
    // Start is called before the first frame update
    public void Start()
    {

        //StartCoroutine(Talk());
        Invoke("ActiveAnimation", 1);
        
        

    }
    
    IEnumerator Talk()
    {
        yield return new WaitForSeconds(Random.Range(3, 6));
        animator.SetInteger("state", Random.Range(0, 4));
        Debug.Log("Animation");
        animator.SetTrigger("Talk");
      /*  if (animator.GetInteger("state") == 0)
        {
            audio1.Play();
        }
        if (animator.GetInteger("state") == 1)
        {
            audio2.Play();
        }
        if (animator.GetInteger("state") == 2)
        {
            audio3.Play();
        }
        if (animator.GetInteger("state") == 3)
        {
            audio4.Play();
        }*/
        StartCoroutine(Talk());
    }
    void ActiveAnimation()
    {
        animator.SetInteger("state", 2);
        animator.SetTrigger("Talk");
        

    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Fail"))
        {
            audio2.Play(); 
        }
        if (collision.gameObject.CompareTag("Sucsses"))
        {
            audio3.Play(); 
        }
        
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Spike"))
        {
            audio2.Play();
            gm.totalNumberOfFruitsLeft--;
            GameManeger.failCounter++;
            Debug.Log("Fail:" + GameManeger.failCounter + "totalNumerLeft: " + gm.totalNumberOfFruitsLeft);
            if (GameManeger.failCounter > gm.minforLevelSucsess || ((gm.totalNumberOfFruitsLeft == 0) && (!GameManeger.isLevelSucsess)))
            {
                GameManeger.isLevelFail = true;
                HealthSystem.health--;
            }
            else if (GameManeger.SucsessCounter >= gm.minforLevelSucsess && gm.totalNumberOfFruitsLeft == 0)
                GameManeger.isLevelSucsess = true;
            rigidbody2.bodyType = RigidbodyType2D.Static;
            Invoke("Fruitdeath", 2);

        }
    }

    public void Fruitdeath()
    {

        gameObject.SetActive(false);
    }







}
