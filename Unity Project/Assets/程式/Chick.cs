using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Chick : MonoBehaviour
{
    public float jump;
    public bool isDead;
    public float turnSpeed;
    public float trunLeftSpeed;
    public float trunRightSpeed;
    public GameObject EndWindow;
    private Rigidbody2D Rigidbody2D;
    private bool startRotate;
    private bool turnBack;

    
    void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
        
    }
    
    
    void Update()
    {
        //Debug.Log(startRotate);
        //Debug.Log(turnBack);
        //Debug.Log(transform.rotation.z);
        if (Input.GetKeyDown(KeyCode.Mouse0) && EndWindow.activeSelf == false)
        {
            GameObject.Find("GM").GetComponent<GameManger>().enabled = true;
            Rigidbody2D.gravityScale = 1;
            Jump();   
        }

        if (transform.rotation.z * 360 >= 90)
        {
            transform.DORotate(new Vector3(0, 0, -60), trunRightSpeed);
        }
    }

    private void Jump()
    {
        Rigidbody2D.AddForce(transform.up * jump,ForceMode2D.Impulse);
        transform.DORotate(new Vector3(0, 0, 90), trunLeftSpeed);
        

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("地板及水管"))
        {
            EndWindow.SetActive(true);
        }
    }
}
