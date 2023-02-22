using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

public class fruit_animation : MonoBehaviour
{
    
    private Animator animator;
    private void Awake()
    {
        animator = GetComponent<Animator>();
        
        
    }
    // Start is called before the first frame update
    public void Start()
    {
        StartCoroutine(Talk());
    }
    IEnumerator Talk()
    {
        yield return new WaitForSeconds(Random.Range(3, 6));
        animator.SetInteger("state", Random.Range(0, 4));
        Debug.Log("state=  " + animator.GetInteger("state"));
        animator.SetTrigger("Talk");
        StartCoroutine(Talk());
    }
    
    
         
    
    
    
}
