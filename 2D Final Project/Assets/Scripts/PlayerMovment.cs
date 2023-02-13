using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    public float speed = 5f;
    public float jumpingPower = 10f;
    private bool isOnPlatform = false;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask platform;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector2 direction = new Vector2(horizontal, vertical);
        rb.AddForce(direction * speed);

        if (Input.GetKeyDown(KeyCode.UpArrow) && isOnPlatform)
        {
            rb.AddForce(Vector2.up * jumpingPower, ForceMode2D.Impulse);
            isOnPlatform= false;
        }
    }
    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Platform"))
        {
            isOnPlatform = true;
        }
    }
}
