using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class Chick : MonoBehaviour
{
    public float jump;
    public bool isDead;
    //public float turnSpeed;
    public float angle;
    //public float trunLeftSpeed;
    //public float trunRightSpeed;
    public GameObject goScore;
    private Rigidbody2D r2D;
    //private bool startRotate;
    //private bool turnBack;
    private GameManger GM;

    private void Awake()
    {
        Screen.SetResolution(500, 1280, false);
    }
    void Start()
    {
        
        r2D = GetComponent<Rigidbody2D>();
        GM = GameObject.Find("GM").GetComponent<GameManger>();
    }
    
    
    void Update()
    {
        
        //Debug.Log(startRotate);
        //Debug.Log(turnBack);
        //Debug.Log(transform.rotation.z);


        //if (transform.rotation.z * 360 >= 90)
        //{
        //    transform.DORotate(new Vector3(0, 0, -60), trunRightSpeed);
        //}
    }
    private void FixedUpdate()
    {
        Jump();
    }
    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && GM.EndWindow.activeSelf == false)
        {
            GM.enabled = true;
            goScore.SetActive(true);
            r2D.Sleep();
            r2D.gravityScale = 1;
            r2D.AddForce( new Vector2(0, jump) );//transform.up:區域作標
        }
        r2D.SetRotation(angle * r2D.velocity.y);
        //transform.DORotate(new Vector3(0, 0, 90), trunLeftSpeed);
        

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("地板及水管"))
        {
            GM.GameOver();
            
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("地板及水管"))
        {
            GM.GameOver();

        }
    }
}
