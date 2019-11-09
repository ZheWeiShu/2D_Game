using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chick : MonoBehaviour
{
    public float jump;
    public bool isDead;
    public GameObject EndWindow;
    private Rigidbody2D Rigidbody2D;

    
    void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && EndWindow.activeSelf == false)
        {
            Rigidbody2D.gravityScale = 1;
            Jump();
        }
    }

    private void Jump()
    {
        Rigidbody2D.AddForce(transform.up * jump,ForceMode2D.Impulse);
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("地板及水管"))
        {
            EndWindow.SetActive(true);
        }
    }
}
